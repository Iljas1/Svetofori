/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 04.05.2019
 * Время: 20:58
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Светофоры
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 fr1 = new Form1();
			fr1.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form3 fr3 = new Form3();
			fr3.Show();
			Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form4 fr4 = new Form4();
			fr4.Show();
			Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Form5 fr5 = new Form5();
			fr5.Show();
			Hide();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Form6 fr6 = new Form6();
			fr6.Show();
			Hide();
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Разработчик: Салихов Ильяс Расихович");
		}
	}
}
