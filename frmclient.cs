/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* This code is generated by a tool and is provided "as is", without warranty of any kind,
* express or implied, including but not limited to the warranties of merchantability,
* fitness for a particular purpose and non-infringement.
* In no event shall the authors or copyright holders be liable for any claim, damages or
* other liability, whether in an action of contract, tort or otherwise, arising from,
* out of or in connection with the software or the use or other dealings in the software.
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace SNCF_2
{
	public partial class frmclient : Form
	{
		private Model3 ctx;
		
		public frmclient()
		{
			InitializeComponent();
		}
		
		private void frmclient_Load(object sender, EventArgs e)
		{
			ctx = new Model3();
			ctx.client.Load();
			BindingList<client> _entities = ctx.client.Local.ToBindingList();
			clientBindingSource.DataSource = _entities;
			this.idclientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "idclient", true ));
			this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nom", true ));
			this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "age", true ));
			this.reductionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "reduction", true ));
			this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "login", true ));
			this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "password", true ));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			clientBindingSource.EndEdit();
			ctx.SaveChanges();
			
		}
		
		private void frmclient_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void idclientTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( idclientTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( idclientTextBox, "The field idclient is required" ); 
			}
			int v;
			string s = idclientTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( idclientTextBox, "The field idclient must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( idclientTextBox, "" ); } 
		}
		
		private void nomTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( nomTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( nomTextBox, "The field nom is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( nomTextBox, "" ); } 
		}
		
		private void ageTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( ageTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( ageTextBox, "The field age is required" ); 
			}
			int v;
			string s = ageTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( ageTextBox, "The field age must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( ageTextBox, "" ); } 
		}
		
		private void reductionTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( reductionTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( reductionTextBox, "The field reduction is required" ); 
			}
			double v;
			string s = reductionTextBox.Text;
			if( !double.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( reductionTextBox, "The field reduction must be double." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( reductionTextBox, "" ); } 
		}
		
		private void loginTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( loginTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( loginTextBox, "The field login is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( loginTextBox, "" ); } 
		}
		
		private void passwordTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( passwordTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( passwordTextBox, "The field password is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( passwordTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			clientBindingSource.AddNew();
		}
	}
}
