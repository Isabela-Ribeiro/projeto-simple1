using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
	class Program
	{
		

		static void Main(string[] args)
		{

			string[] nome = new string[30];
			double[] nota1 = new double[15];
			double[] nota2 = new double[15];
			double[] nota3 = new double[15];
			double[] nota4 = new double[15];
			double[] media = new double[20];
			bool[] ativo = new bool[10];
			int i= 0;
			int j = 0;
			int k = 0;
			int l = 0;
			int n = 0;
			int cont =0 ;
			int menu;

			do
			{

				Console.WriteLine("MENU PRINCIPAL\n");
				Console.WriteLine(" 1 - CADASTRO DE ALUNOS");
				Console.WriteLine(" 2 - ALTERAR ALUNO     ");
				Console.WriteLine(" 3 - EXCLUIR ALUNO      ");
				Console.WriteLine(" 4 - PESQUISAR ALUNO    ");
				Console.WriteLine(" 5 - MOSTRAR LISTA      ");
				Console.WriteLine(" 6 - MOSTRAR MELHOR ALUNO DO BIMESTRE ");
				Console.WriteLine(" 7 - MOSTRAR PIOR ALUNO DO BIMESTRE  ");
				Console.WriteLine(" 8 - MOSTRAR MELHOR ALUNO DO ANO   ");
				Console.WriteLine(" 9 - MOSTRAR PIOR ALUNO DO ANO ");
				Console.WriteLine(" 0 - SAIR                 ");

				 menu = Int16.Parse(Console.ReadLine());
				
				switch (menu)
				{
					case 1:
						Console.WriteLine("CADASTRO DO ALUNO");

							Console.Write("Nome do Aluno:\t ");
							nome[cont] = Console.ReadLine();

							Console.WriteLine("Insira a nota do 1 bimestre: \t");
							nota1[cont] = Convert.ToDouble(Console.ReadLine());

							Console.WriteLine("Insira a nota do 2 bimestre: \t");
							nota2[cont] = Convert.ToDouble(Console.ReadLine());

							Console.WriteLine("Insira a nota do 3 bimestre: \t");
							nota3[cont] = Convert.ToDouble(Console.ReadLine());

							Console.WriteLine("Insira a nota do 4 bimestre: \t ");
							nota4[cont] = Convert.ToDouble(Console.ReadLine());

						ativo[cont] = true;

						
						media[cont] = (nota1[cont] + nota2[cont] + nota3[cont] + nota4[cont]) / 4;	

						if (media[cont] >= 6)
						{
							Console.WriteLine("Aluno Aprovado!");
						}
						else
						{
							Console.WriteLine("Aluno Reprovado!");
						}
						cont++;

						break;
					case 2:

						Console.Clear();
						Console.WriteLine("ALTERAR DADOS DO ALUNO");

						Console.WriteLine("Digite o indice do aluno para alterar:");
						int escolha = Int16.Parse(Console.ReadLine());
						
						Console.WriteLine("Aluno " + nome[cont] + " selecionado \n Qual dado deseja alterar? \n");
						Console.WriteLine("[1] - Nome ");
						Console.WriteLine("[2] - Nota");
						int opcao = Int16.Parse(Console.ReadLine());

                        if (ativo[escolha] == true) {
							switch (opcao)
							{
								case 1:
									Console.WriteLine("Digite o novo Nome: ");
									nome[escolha] = Console.ReadLine();

									Console.WriteLine("------------------------------------\n");
									Console.WriteLine("	 Nome alterado com Sucesso \n");
									Console.WriteLine("------------------------------------ \n \n");
									break;
								case 2:

									Console.Write("Digite o bimestre para alterar:");
									double novaNota = Convert.ToDouble(Console.ReadLine());

									if (novaNota == 1)
									{
										Console.WriteLine("Insira a nota do 1 bimestre: \t");
										nota1[escolha] = Convert.ToDouble(Console.ReadLine());
									}
									if (novaNota == 2)
									{
										Console.WriteLine("Insira a nota do 2 bimestre: \t");
										nota2[escolha] = Convert.ToDouble(Console.ReadLine());
									}
									if (novaNota == 3)
									{
										Console.WriteLine("Insira a nota do 3 bimestre: \t");
										nota3[escolha] = Convert.ToDouble(Console.ReadLine());
									}
									if (novaNota == 4)
									{
										Console.WriteLine("Insira a nota do 4 bimestre: \t ");
										nota4[escolha] = Convert.ToDouble(Console.ReadLine());
									}


									media[escolha] = (nota1[escolha] + nota2[escolha] + nota3[escolha] + nota4[escolha]) / 4;
									Console.WriteLine("media : " + media[escolha]);

									Console.WriteLine("------------------------------------\n");
									Console.WriteLine("	 Nota alterado com Sucesso \n");
									Console.WriteLine("------------------------------------ \n \n");
									break;
							}
                        }
                        else
                        {
							Console.Write("Aluno não encontrado!");
                        }
						break;

					case 3:
						Console.Clear();
						Console.WriteLine("EXCLUIR CADASTRO");

						Console.WriteLine("Digite o indice do aluno para ser excluido:");
						 int opc = Int16.Parse(Console.ReadLine());
						
                        if (ativo[opc] == true)
                        {
							nome[opc] = "\0";
							nota1[opc] = 0;
							nota2[opc] = 0;
							nota3[opc] = 0;
							nota4[opc] = 0;
							media[opc] = 0;
							ativo[opc] = false;
							
						Console.WriteLine("Aluno Excluido com sucesso");
                        }
                        else
                        {
							Console.WriteLine("Aluno não encontrado!");
                        }
																
						break;
					

					case 4:
						Console.Clear();
						Console.WriteLine("BUSCA DE CADASTRO");
									
						bool verificar = false;
					
						Console.WriteLine("DIGITE O INDICE DO ALUNO:\n");
						int cod = Int16.Parse(Console.ReadLine());

						if (ativo[cod] == false)
						{
							Console.WriteLine("------------------------------------\n");
							Console.WriteLine("ALUNO NÃO ENCONTADO\n");
							Console.WriteLine("------------------------------------ \n \n");
						}
						if (ativo[cod] == true)
						{
							Console.WriteLine("NOME DO ALUNO:\n" + nome[cod]);
							Console.WriteLine("MEDIA DO ALUNO:\n" + media[cod]);
						}
							break;
					case 5:
						Console.Clear();
					
						Console.WriteLine("LISTA DE ALUNOS");
						
						Console.WriteLine("Alunos Cadastrado:\n");

						for (i = 0; i < cont; i++)
						{
							if (ativo[i]==true)
							{
								Console.WriteLine("Nome do aluno: " + nome[i]);
								Console.WriteLine("Nota 1 bim: " + nota1[i] + "\n Nota 2bim: " + nota2[i] + " \n Nota 3bim: " + nota3[i] + "\n Nota 4 bim: " + nota4[i]);
								Console.WriteLine("media : " + media[i]);

						Console.WriteLine(" ");
                            }                         
						}
						break;

					case 6:
						Console.Clear();
						Console.WriteLine("MELHOR ALUNO DO BIMESTRE:");

						

						Console.WriteLine("Digite o bimestre para saber qual foi o melhor aluno:");
						int bimMaior = Int16.Parse(Console.ReadLine());

						double maiorNota1 = 0;
						double maiorNota2 = 0;
						double maiorNota3 = 0;
						double maiorNota4 = 0;


						if (bimMaior == 1)
						{

							for (i = 0; i < cont; i++)
							{
								if (nota1[i] > maiorNota1)
								{

									maiorNota1 = nota1[i];
									k = i;
								}
							}
							Console.WriteLine(nome[k] + " é o melhor aluno do 1 bimestre");
						}
						else if (bimMaior == 2)
						{

							for (i = 0; i < cont; i++)
							{
								if (nota2[i] > maiorNota2)
								{

									maiorNota2 = nota2[i];
									k = i;
								}
							}
							Console.WriteLine(nome[k] + " é o melhor aluno do 2 bimestre");
						}
						else if (bimMaior == 3)
						{

							for (i = 0; i < cont; i++)
							{
								if (nota3[i] > maiorNota3)
								{

									maiorNota3 = nota3[i];
									k = i;
								}
							}
							Console.WriteLine(nome[k] + " é o melhor aluno do 3 bimestre");
						}
						else if (bimMaior == 4)
						{

							for (i = 0; i < cont; i++)
							{
								if (nota4[i] > maiorNota4)
								{

									maiorNota4 = nota4[i];
									k = i;
								}
							}
							Console.WriteLine(nome[k] + " é o melhor aluno do 4 bimestre");
							Console.WriteLine("Com a nota : " + nota4[i]);
						}
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("MELHOR ALUNO DO BIMESTRE:");

						double piorNota1 = media[0];
						double piorNota2 = media[0];
						double piorNota3 = media[0];
						double piorNota4 = media[0];
						int s=0;

						Console.WriteLine("Digite o bimestre para saber qual foi o pior aluno:");
						int bimPior = Int16.Parse(Console.ReadLine());

						if (bimPior == 1)
						{
							for (i = 0; i < cont; i++)
								{
                                if (ativo[i] == true)
                                {
									if (nota1[i] < piorNota1)
									{
										s = i;
										piorNota1 = nota1[i];

									}
								}
									
							}
								Console.WriteLine(nome[s] + " é o pior aluno do 1 bimestre");
						}
						if (bimPior == 2)
							{
							for (i = 0; i < cont; i++)
							{
                                if (ativo[i] == true)
                                {
									if (nota2[i] < piorNota2)
									{
										s = i;
										piorNota2 = nota2[i];

									}
								}
							}
								Console.WriteLine(nome[s] + " é o pior aluno do 2 bimestre");
						}
						if (bimPior == 3)
						{
							for (i = 0; i < cont; i++)
							{
								if (ativo[i] == true)
								{
									if (nota3[i] < piorNota3)
									{
										s = i;
										piorNota3 = nota3[i];

									}
								}
									
							}
								Console.WriteLine(nome[s] + " é o pior aluno do 3 bimestre");
						}
						if (bimPior == 4)
							{
							for (i = 0; i < cont; i++)
							{
								if (ativo[i] == true)
                                {
									if (nota4[i] < piorNota4)
									{
										s = i;
										piorNota4 = nota4[i];

									}
								}	
							}
								Console.WriteLine(nome[s] + " é o pior aluno do 4 bimestre");
						}
							
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("MELHOR ALUNO DO ANO!!!");
						double maior = 0;

						for (i = 0; i < cont; i++)
						{
							if (media[i] > maior)
							{
								j = i;
								maior = maior +  media[n];
								
							}
						}
						Console.WriteLine( nome[j] + " é o melhor aluno do ano" );
						Console.WriteLine("Com a  : " + maior);

						break;
					case 9:
						Console.Clear();
						Console.WriteLine("PIOR ALUNO DO ANO!");
					
					
						double menor ;
						menor = media[0];
						for (i = 0; i < cont; i++)
						{
							if (media[i]<menor)
							{
                                if (ativo[i] == true)
                                {
									l = i;
									menor = media[i];
								}
								
								
							}
						}
						Console.WriteLine( nome[l] + " é o pior aluno do ano");

						break;
					case 0:
						Console.WriteLine("Obrigado!\n");
						break;
					default:
						Console.WriteLine("Opcao invalida!\nTente novamente:\n");
						break;
				}

			} while (menu != 0);

				Console.ReadLine();
		}
	}
}