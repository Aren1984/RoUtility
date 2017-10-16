using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RO_Data_Editor {

    public delegate void ParseSubTreeDelegate( String strForder, TreeNode kParent );

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ParseTree();
        }

        static void ParseTreeImp( String strForder, TreeNode kParent ) {
            if ( kParent.Nodes.Count > 0 ) {
                return;
            }
            var kLocalDirectories = Directory.GetDirectories( strForder );
            foreach ( var kDirectory in kLocalDirectories ) {
                var kNode = kParent.Nodes.Add( kDirectory );
                kNode.Tag = delegate () {
                }
            }
            var kLocalFiles = Directory.GetFiles( strForder );
            foreach ( var kFile in kLocalFiles ) {
                kParent.Nodes.Add( kFile );
            }
        }

        private void ParseTree() {
            ParseSubTreeDelegate fnParser = null;
            fnParser = delegate ( String strForder, TreeNode kParent ) {
                if ( kParent.Nodes.Count > 0 ) {
                    return;
                }
                var kLocalDirectories = Directory.GetDirectories( strForder );
                foreach ( var kDirectory in kLocalDirectories ) {
                    var kNode = kParent.Nodes.Add( kDirectory );
                    kNode.Tag = fnParser( kDirectory, kNode );
                }
                var kLocalFiles = Directory.GetFiles( strForder );
                foreach ( var kFile in kLocalFiles ) {
                    kParent.Nodes.Add( kFile );
                }
            };

            var kFiles = Directory.GetFiles( @"C:\Users\ArenChien\Desktop\RO Data\data", "*", SearchOption.AllDirectories );
            uiFileTreeView.BeginUpdate();
            foreach ( var kFile in kFiles ) {
                uiFileTreeView.Nodes.Add( kFile );
            }
            uiFileTreeView.EndUpdate();
        }
        private void uiFileTreeView_BeforeSelect( object sender, TreeViewCancelEventArgs e ) {

        }
    }
}
