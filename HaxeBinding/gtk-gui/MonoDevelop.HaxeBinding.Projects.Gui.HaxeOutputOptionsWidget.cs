
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.HaxeBinding.Projects.Gui
{
	public partial class HaxeOutputOptionsWidget
	{
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table table1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry wOutputDirectoryEntry;
		private global::Gtk.Button wOutputDirectoryButton;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Entry wOutputFileNameEntry;
		private global::Gtk.Entry wParametersEntry;
		private global::Gtk.Label GtkLabel1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.HaxeBinding.Projects.Gui.HaxeOutputOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.HaxeBinding.Projects.Gui.HaxeOutputOptionsWidget";
			// Container child MonoDevelop.HaxeBinding.Projects.Gui.HaxeOutputOptionsWidget.Gtk.Container+ContainerChild
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
			this.wOutputDirectoryEntry = new global::Gtk.Entry ();
			this.wOutputDirectoryEntry.CanFocus = true;
			this.wOutputDirectoryEntry.Name = "wOutputDirectoryEntry";
			this.wOutputDirectoryEntry.IsEditable = true;
			this.wOutputDirectoryEntry.InvisibleChar = '•';
			this.hbox1.Add (this.wOutputDirectoryEntry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.wOutputDirectoryEntry]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.wOutputDirectoryButton = new global::Gtk.Button ();
			this.wOutputDirectoryButton.CanFocus = true;
			this.wOutputDirectoryButton.Name = "wOutputDirectoryButton";
			// Container child wOutputDirectoryButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w6.LabelProp = global::Mono.Unix.Catalog.GetString ("Choose...");
			w3.Add (w6);
			w2.Add (w3);
			this.wOutputDirectoryButton.Add (w2);
			this.hbox1.Add (this.wOutputDirectoryButton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.wOutputDirectoryButton]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Extra compiler parameters");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Output file");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Output path");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.wOutputFileNameEntry = new global::Gtk.Entry ();
			this.wOutputFileNameEntry.CanFocus = true;
			this.wOutputFileNameEntry.Name = "wOutputFileNameEntry";
			this.wOutputFileNameEntry.IsEditable = true;
			this.wOutputFileNameEntry.InvisibleChar = '•';
			this.table1.Add (this.wOutputFileNameEntry);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.wOutputFileNameEntry]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.wParametersEntry = new global::Gtk.Entry ();
			this.wParametersEntry.CanFocus = true;
			this.wParametersEntry.Name = "wParametersEntry";
			this.wParametersEntry.IsEditable = true;
			this.wParametersEntry.InvisibleChar = '•';
			this.table1.Add (this.wParametersEntry);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.wParametersEntry]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Output</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.Add (this.frame1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.wOutputDirectoryButton.Clicked += new global::System.EventHandler (this.OnWOutputDirectoryButtonClicked);
		}
	}
}