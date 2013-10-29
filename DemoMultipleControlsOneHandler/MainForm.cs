using System.Windows.Forms;

namespace DemoMultipleControlsOneHandler {

  public partial class MainForm : Form {

    public MainForm() {

      InitializeComponent();
    }

    // Shared handler for Click event
    private void HandleClick( object sender, System.EventArgs e ) {

      MessageBox.Show( "Clicked!" );
    }

    // Shared handler for KeyPress event

    // Note the signature is accepting a KeyPressEventArgs as the 
    // second parameter.
    private void HandleKeyPress( object sender, KeyPressEventArgs e ) {

      MessageBox.Show( "Key Pressed!" );
    }
  }
}