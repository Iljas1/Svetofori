/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 05.05.2019
 * Время: 8:06
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Светофоры
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		    MainForm fr = new MainForm();
			fr.Show();
			Hide();	
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			pictureBox11.BackColor = Color.YellowGreen;
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			pictureBox7.BackColor = Color.YellowGreen;
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			pictureBox10.BackColor = Color.YellowGreen;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if((pictureBox7.BackColor == Color.YellowGreen)&&(pictureBox10.BackColor == Color.YellowGreen)&&(pictureBox11.BackColor == Color.YellowGreen))
			{
				Form2 fr2 = new Form2();
				fr2.Show();
				Hide();
			}
		}
	}
}
