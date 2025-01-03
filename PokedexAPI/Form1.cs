using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;


namespace FormAPI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = searchBar.Text;
			if (input != String.Empty)
			{
				FetchPokemon(input);
			}
			else
			{
				MessageBox.Show("Enter Pokemon or ID");
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public Pokemon pokemon = new Pokemon();
		public HttpClient client = new HttpClient();
		public Random random = new Random();
		public bool shiny = false;
		public async Task FetchPokemon(string input)
		{
			string text = null;
			try
			{
				HttpResponseMessage response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{input.ToLower()}");
				if (response.IsSuccessStatusCode)
				{
					text = await response.Content.ReadAsStringAsync();
					pokemon = JsonSerializer.Deserialize<Pokemon>(text);
					LoadData(pokemon);
				}
				else
				{
					MessageBox.Show("Not Valid");
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show("Not Valid");
			}

		}
		public async void LoadData(Pokemon pokemon)
		{
			shinyButton.Enabled = true;
			shinyButton.Text = "Shiny";
			shiny = false;
			TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
			await UpdateImageFromUrl(pokemon.sprites.other.officialartwork.front_default);
			name.Text = myTI.ToTitleCase(pokemon.name);

			idNum.Text = $"#{pokemon.id}";

			type1.Text = myTI.ToTitleCase(pokemon.types[0].type.name);
			TypeColour(pokemon.types[0].type.name, type1);
			type1.Show();
			if (pokemon.types.Count == 2)
			{
				type2.Text = myTI.ToTitleCase(pokemon.types[1].type.name);
				TypeColour(pokemon.types[1].type.name, type2);
				type2.Show();
			}
			else
			{
				type2.Hide();
			}
			
			heightNum.Text = $"{pokemon.height / 10}m";
			weightNum.Text = $"{pokemon.weight / 10}kg";

			LoadBar(pokemon, hpBar, hpNum, 0);
			LoadBar(pokemon, attackBar, attackNum, 1);
			LoadBar(pokemon, defenseBar, defenseNum, 2);
			LoadBar(pokemon, spAtkBar, spAtkNum, 3);
			LoadBar(pokemon, spDefBar, spDefNum, 4);
			LoadBar(pokemon, speedBar, speedNum, 5);

			hpNum.Text = $"{pokemon.stats[0].base_stat}";
			hpBar.Width = pokemon.stats[0].base_stat;

			attackNum.Text = $"{pokemon.stats[1].base_stat}";
			attackBar.Width = pokemon.stats[1].base_stat;

			defenseNum.Text = $"{pokemon.stats[2].base_stat}";
			defenseBar.Width = pokemon.stats[2].base_stat;

			spAtkNum.Text = $"{pokemon.stats[3].base_stat}";
			spAtkBar.Width = pokemon.stats[3].base_stat;

			spDefNum.Text = $"{pokemon.stats[4].base_stat}";
			spDefBar.Width = pokemon.stats[4].base_stat;

			speedNum.Text = $"{pokemon.stats[5].base_stat}";
			speedBar.Width = pokemon.stats[5].base_stat;


			int total = 0;
			for (int i = 0; i < pokemon.stats.Count; i++)
			{
				total += pokemon.stats[i].base_stat;
			}
			totalNum.Text = $"{total}";
		}
		public static void TypeColour(string type, Label label)
		{
			if (type == "normal")
			{
				label.BackColor = Color.Silver;
			}
			else if (type == "fire")
			{
				label.BackColor = Color.OrangeRed;
			}
			else if (type == "water")
			{
				label.BackColor = Color.DodgerBlue;
			}
			else if (type == "electric")
			{
				label.BackColor = Color.Yellow;
			}
			else if (type == "grass")
			{
				label.BackColor = Color.LimeGreen;
			}
			else if (type == "ice")
			{
				label.BackColor = Color.PaleTurquoise;
			}
			else if (type == "fighting")
			{
				label.BackColor = Color.IndianRed;
			}
			else if (type == "poison")
			{
				label.BackColor = Color.MediumOrchid;
			}
			else if (type == "ground")
			{
				label.BackColor = Color.Khaki;
			}
			else if (type == "flying")
			{
				label.BackColor = Color.CornflowerBlue;
			}
			else if (type == "psychic")
			{
				label.BackColor = Color.HotPink;
			}
			else if (type == "bug")
			{
				label.BackColor = Color.YellowGreen;
			}
			else if (type == "rock")
			{
				label.BackColor = Color.Tan;
			}
			else if (type == "ghost")
			{
				label.BackColor = Color.SlateBlue;
			}
			else if (type == "dragon")
			{
				label.BackColor = Color.MediumSlateBlue;
			}
			else if (type == "dark")
			{
				label.BackColor = Color.SaddleBrown;
			}
			else if (type == "steel")
			{
				label.BackColor = Color.LightGray;
			}
			else if (type == "fairy")
			{
				label.BackColor = Color.Plum;
			}
		}
		public static void LoadBar(Pokemon pokemon, Label bar, Label textBox, int index)
		{
			int num = pokemon.stats[index].base_stat;

			if (num < 30)
			{
				bar.BackColor = Color.Red;
			}
			else if (num < 60)
			{
				bar.BackColor = Color.Coral;
			}
			else if (num < 90)
			{
				bar.BackColor = Color.GreenYellow;
			}
			else if (num < 120)
			{
				bar.BackColor = Color.LimeGreen;
			}
			else
			{
				bar.BackColor = Color.LightSeaGreen;
			}
			bar.Width = num;
			textBox.Text = $"{num}";
		}
		private async Task UpdateImageFromUrl(string imageUrl)
		{
			using (HttpClient client = new HttpClient())
			{
				byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);

				using (MemoryStream ms = new MemoryStream(imageBytes))
				{
					Image image = Image.FromStream(ms);

					// Set the image to the PictureBox
					pictureBox1.Image = image;
					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void name_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click_1(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click_2(object sender, EventArgs e)
		{

		}

		private void label7_Click_1(object sender, EventArgs e)
		{

		}

		private void label3_Click_3(object sender, EventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void label3_Click_4(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (shiny == false)
			{
				UpdateImageFromUrl(pokemon.sprites.other.officialartwork.front_shiny);
				shinyButton.Text = "Shiny: on";
				shiny = true;
			}
			else
			{
				UpdateImageFromUrl(pokemon.sprites.other.officialartwork.front_default);
				shinyButton.Text = "Shiny: off";
				shiny = false;
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int num = random.Next(1, 1026);
			FetchPokemon(num.ToString());
		}
	}
}
