
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.HaxeBinding.Projects.Gui
{
	public partial class NMEProjectOptionsWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table table1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry TargetNMMLFileEntry;
		private global::Gtk.Button TargetNMMLFileButton;
		private global::Gtk.Label TargetNMMLFileLabel;
		private global::Gtk.Label GtkLabel1;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Table table2;
		private global::Gtk.Entry AdditionalArgumentsEntry;
		private global::Gtk.Label AdditionalArgumentsLabel;
		private global::Gtk.Label GtkLabel2;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.HaxeBinding.Projects.Gui.NMEProjectOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.HaxeBinding.Projects.Gui.NMEProjectOptionsWidget";
			// Container child MonoDevelop.HaxeBinding.Projects.Gui.NMEProjectOptionsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.TopPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(12));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.TargetNMMLFileEntry = new global::Gtk.Entry ();
			this.TargetNMMLFileEntry.CanFocus = true;
			this.TargetNMMLFileEntry.Name = "TargetNMMLFileEntry";
			this.TargetNMMLFileEntry.IsEditable = true;
			this.TargetNMMLFileEntry.InvisibleChar = '•';
			this.hbox1.Add (this.TargetNMMLFileEntry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.TargetNMMLFileEntry]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.TargetNMMLFileButton = new global::Gtk.Button ();
			this.TargetNMMLFileButton.CanFocus = true;
			this.TargetNMMLFileButton.Name = "TargetNMMLFileButton";
			// Container child TargetNMMLFileButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-file", global::Gtk.IconSize.Menu);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w6.LabelProp = global::Mono.Unix.Catalog.GetString ("Choose...");
			w3.Add (w6);
			w2.Add (w3);
			this.TargetNMMLFileButton.Add (w2);
			this.hbox1.Add (this.TargetNMMLFileButton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.TargetNMMLFileButton]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.TargetNMMLFileLabel = new global::Gtk.Label ();
			this.TargetNMMLFileLabel.Name = "TargetNMMLFileLabel";
			this.TargetNMMLFileLabel.Xalign = 0F;
			this.TargetNMMLFileLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Target NMML file:");
			this.table1.Add (this.TargetNMMLFileLabel);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.TargetNMMLFileLabel]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Code Generation</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.vbox1.Add (this.frame1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
			w15.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			this.GtkAlignment2.TopPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.AdditionalArgumentsEntry = new global::Gtk.Entry ();
			this.AdditionalArgumentsEntry.CanFocus = true;
			this.AdditionalArgumentsEntry.Name = "AdditionalArgumentsEntry";
			this.AdditionalArgumentsEntry.IsEditable = true;
			this.AdditionalArgumentsEntry.InvisibleChar = '•';
			this.table2.Add (this.AdditionalArgumentsEntry);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.AdditionalArgumentsEntry]));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.AdditionalArgumentsLabel = new global::Gtk.Label ();
			this.AdditionalArgumentsLabel.Name = "AdditionalArgumentsLabel";
			this.AdditionalArgumentsLabel.Xalign = 0F;
			this.AdditionalArgumentsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Additional arguments:");
			this.table2.Add (this.AdditionalArgumentsLabel);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.AdditionalArgumentsLabel]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table2);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Additional Options</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel2;
			this.vbox1.Add (this.frame2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame2]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.TargetNMMLFileButton.Clicked += new global::System.EventHandler (this.OnTargetNMMLFileButtonClicked);
		}
	}
}
