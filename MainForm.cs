/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 30/09/2019
 * Time: 20:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_dados
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
		}
		int contAcertos=0, contClick=0;
		Random rnd = new Random ();
		
		//Codificação BOTÃO DESCUBRA
		void Button1Click(object sender, EventArgs e)
		{
			int n = rnd.Next(1, 7);
			button1.Text = n.ToString();
			
			//Estrutura de decisão informando ao usuário se ele acertou o valor que sairá no botão
			if (n == int.Parse(textBox1.Text)) {
				MessageBox.Show("Acertou! Duvido que você consiga de novo...");
				
				contAcertos++;
				label2.Text = contAcertos.ToString();
				
				textBox1.Focus();
				textBox1.Text = " ";
				
			} else {
				MessageBox.Show("Errou! Tente novamente!");
				
				textBox1.Focus();
				textBox1.Text = " ";
			}
			
			//Estrutura para quando o usuário usar todas as suas chances
			contClick++;
			if (contClick==3) {
				MessageBox.Show("FIM DE JOGO");
			}
		}
		
		//Codificação PICTURE BOX INTERROGAÇÃO
		void PictureBox1Click(object sender, EventArgs e)
		{
			int n = rnd.Next(1, 7);
			pictureBox1.Load("dado"+n+".png");
			
			//Estrutura de decisão informando ao usuário se ele acertou o valor que sairá na PICTURE BOX
			if ((int.Parse(textBox1.Text)<1) || (int.Parse(textBox1.Text)>6))
			{
				MessageBox.Show("Você não sabe quantos lados tem um dado?");
			} 
			else if ( n == int.Parse(textBox1.Text) )    {
				MessageBox.Show("Acertou! Duvido que você consiga de novo...");
				
				textBox1.Clear();
				textBox1.Focus();
				
				contAcertos++;
				label2.Text = contAcertos.ToString();
				
				}
			
			else {
				MessageBox.Show("Errou! Tente novamente!");
				
				textBox1.Clear();
				textBox1.Focus();
			}
			
			//Estrutura para quando o usuário usar todas as suas chances
			contClick++;
			if (contClick==3) {
				pictureBox1.Enabled = false;
				MessageBox.Show("FIM DE JOGO!");
				/*MessageBox.Show("Deseja reiniciar a partida?");
				return;*/
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
		//PARA REINICIAR A PARTIDA
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Focus();
			textBox1.Text = " ";
			
			label2.Text = " - ";
		}
	}
}
