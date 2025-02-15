﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Graph;
using System.Drawing.Drawing2D;
using Graph.Compatibility;
using Graph.Items;

namespace GraphNodes
{
	public partial class EditorForm : Form
	{
		public EditorForm()
		{
			InitializeComponent();

			graphControl.CompatibilityStrategy = new TagTypeCompatibility();

			var someNode = new Node("My Title");
			someNode.Location = new Point(400, 100);
			var check1Item = new NodeCheckboxItem("Check 1", true, false);
			someNode.AddItem(check1Item);
			someNode.AddItem(new NodeCheckboxItem("Check 2", true, false));
			
			graphControl.AddNode(someNode);

			var colorNode = new Node("Color");
			colorNode.Location = new Point(200, 100);
			var redChannel		= new NodeSliderItem("R", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var greenChannel	= new NodeSliderItem("G", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var blueChannel		= new NodeSliderItem("B", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var colorItem		= new NodeColorItem("Color", Color.Black, false, true);

			EventHandler<NodeItemEventArgs> channelChangedDelegate = delegate(object sender, NodeItemEventArgs args)
			{
				var red = redChannel.Value;
				var green = blueChannel.Value;
				var blue = greenChannel.Value;
				colorItem.Color = Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
			};
			redChannel.ValueChanged		+= channelChangedDelegate;
			greenChannel.ValueChanged	+= channelChangedDelegate;
			blueChannel.ValueChanged	+= channelChangedDelegate;


			colorNode.AddItem(redChannel);
			colorNode.AddItem(greenChannel);
			colorNode.AddItem(blueChannel);

			colorItem.Clicked += new EventHandler<NodeItemEventArgs>(OnColClicked);
			colorNode.AddItem(colorItem);
			colorNode.AddItem(new NodeCheckboxItem("IsTrue", true, true));
			graphControl.AddNode(colorNode);

			var textureNode = new Node("Texture");
			textureNode.Location = new Point(600, 100);
			var imageItem = new NodeImageItem(Properties.Resources.example, 64, 64, false, true) { Tag = 1000f };
			imageItem.Clicked += new EventHandler<NodeItemEventArgs>(OnImgClicked);
			textureNode.AddItem(imageItem);
			graphControl.AddNode(textureNode);

			graphControl.ConnectionAdded	+= new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionAdded);
			graphControl.ConnectionAdding	+= new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionAdding);
			graphControl.ConnectionRemoving += new EventHandler<AcceptNodeConnectionEventArgs>(OnConnectionRemoved);
			graphControl.ShowElementMenu	+= new EventHandler<AcceptElementLocationEventArgs>(OnShowElementMenu);

            //graphControl.Connect(colorItem, check1Item);
            graphControl.Connect(colorNode.titleItem, someNode.titleItem);
			graphControl.Connect(someNode.titleItem, textureNode.titleItem);
		}

		void OnImgClicked(object sender, NodeItemEventArgs e)
		{
			MessageBox.Show("IMAGE");
		}

		void OnColClicked(object sender, NodeItemEventArgs e)
		{
			MessageBox.Show("Color");
		}

		void OnConnectionRemoved(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
		}

		void OnShowElementMenu(object sender, AcceptElementLocationEventArgs e)
		{
			if (e.Element == null)
			{
				// Show a test menu for when you click on nothing
				popupMenu.Text = "(clicked on nothing)";
				contextMenu.Show(e.Position);
				e.Cancel = false;
			} else
			if (e.Element is Node)
			{
				// Show a test menu for a node
				popupMenu.Text = ((Node)e.Element).Title;
				contextMenu.Show(e.Position);
				e.Cancel = false;
			} else
			if (e.Element is NodeItem)
			{
				// Show a test menu for a nodeItem
				popupMenu.Text = e.Element.GetType().Name;
				contextMenu.Show(e.Position);
				e.Cancel = false;
			} else
			{
				// if you don't want to show a menu for this item (but perhaps show a menu for something more higher up) 
				// then you can cancel the event
				e.Cancel = true;
			}
		}

		void OnConnectionAdding(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
		}

        static int counter = 1;
		void OnConnectionAdded(object sender, AcceptNodeConnectionEventArgs e)
		{
			//e.Cancel = true;
			e.Connection.Name = "Connection " + counter ++;
			e.Connection.DoubleClick += new EventHandler<NodeConnectionEventArgs>(OnConnectionDoubleClick);
		}

		void OnConnectionDoubleClick(object sender, NodeConnectionEventArgs e)
		{
			e.Connection.Name = "Connection " + counter++;
		}

		private void SomeNode_MouseDown(object sender, MouseEventArgs e)
		{
			var node = new Node("Some node");
			node.AddItem(new NodeLabelItem("Entry 1", true, false));
			node.AddItem(new NodeLabelItem("Entry 2", true, false));
			node.AddItem(new NodeLabelItem("Entry 3", false, true));
			node.AddItem(new NodeTextBoxItem("TEXTTEXT", false, true));
			node.AddItem(new NodeDropDownItem(new string[] { "1", "2", "3", "4" }, 0, false, false));
			this.DoDragDrop(node, DragDropEffects.Copy);
		}

		private void TextureNode_MouseDown(object sender, MouseEventArgs e)
		{
			var textureNode = new Node("Texture");
			textureNode.Location = new Point(300, 150);
			var imageItem = new NodeImageItem(Properties.Resources.example, 64, 64, false, true);
			imageItem.Clicked += new EventHandler<NodeItemEventArgs>(OnImgClicked);
			textureNode.AddItem(imageItem);
			this.DoDragDrop(textureNode, DragDropEffects.Copy);
		}

		private void ColorNode_MouseDown(object sender, MouseEventArgs e)
		{
			var colorNode = new Node("Color");
			colorNode.Location = new Point(200, 50);
			var redChannel = new NodeSliderItem("R", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var greenChannel = new NodeSliderItem("G", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var blueChannel = new NodeSliderItem("B", 64.0f, 16.0f, 0, 1.0f, 0.0f, false, false);
			var colorItem = new NodeColorItem("Color", Color.Black, false, true);

			EventHandler<NodeItemEventArgs> channelChangedDelegate = delegate(object s, NodeItemEventArgs args)
			{
				var red = redChannel.Value;
				var green = blueChannel.Value;
				var blue = greenChannel.Value;
				colorItem.Color = Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
			};
			redChannel.ValueChanged += channelChangedDelegate;
			greenChannel.ValueChanged += channelChangedDelegate;
			blueChannel.ValueChanged += channelChangedDelegate;


			colorNode.AddItem(redChannel);
			colorNode.AddItem(greenChannel);
			colorNode.AddItem(blueChannel);

			colorItem.Clicked += new EventHandler<NodeItemEventArgs>(OnColClicked);
			colorNode.AddItem(colorItem);

			this.DoDragDrop(colorNode, DragDropEffects.Copy);
		}
    }
}
