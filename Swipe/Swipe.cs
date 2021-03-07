using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;


namespace Swipe
{
    class Swipe
    {
        private string parola_inserire ;
        private bool trovato = false;
        private string[] parole = new string [10000];
        private string[] risultati = new string[3];

        public void set_parola(string parola)
        {
            parola_inserire = parola;
        }

        public string get_parola()
        {
            return parola_inserire;
        }

        public void apertura_file()
        {
            if(parola_inserire!=""){
                switch (parola_inserire[0])
                {
                    case 'a':
                        parole = File.ReadAllLines(@"a.txt");
                        break;

                    case 'b':
                        parole = File.ReadAllLines(@"b.txt");
                        break;

                    case 'c':
                        parole = File.ReadAllLines(@"c.txt");
                        break;

                    case 'd':
                        parole = File.ReadAllLines(@"d.txt");
                        break;

                    case 'e':
                        parole = File.ReadAllLines(@"e.txt");
                        break;

                    case 'f':
                        parole = File.ReadAllLines(@"f.txt");
                        break;

                    case 'g':
                        parole = File.ReadAllLines(@"g.txt");
                        break;

                    case 'h':
                        parole = File.ReadAllLines(@"h.txt");
                        break;

                    case 'i':
                        parole = File.ReadAllLines(@"i.txt");
                        break;

                    case 'l':
                        parole = File.ReadAllLines(@"l.txt");
                        break;

                    case 'm':
                        parole = File.ReadAllLines(@"m.txt");
                        break;

                    case 'n':
                        parole = File.ReadAllLines(@"n.txt");
                        break;

                    case 'o':
                        parole = File.ReadAllLines(@"o.txt");
                        break;

                    case 'p':
                        parole = File.ReadAllLines(@"p.txt");
                        break;

                    case 'q':
                        parole = File.ReadAllLines(@"q.txt");
                        break;

                    case 'r':
                        parole = File.ReadAllLines(@"r.txt");
                        break;

                    case 's':
                        parole = File.ReadAllLines(@"s.txt");
                        break;

                    case 't':
                        parole = File.ReadAllLines(@"t.txt");
                        break;

                    case 'u':
                        parole = File.ReadAllLines(@"u.txt");
                        break;

                    case 'v':
                        parole = File.ReadAllLines(@"v.txt");
                        break;

                    case 'w':
                        parole = File.ReadAllLines(@"w.txt");
                        break;

                    case 'x':
                        parole = File.ReadAllLines(@"x.txt");
                        break;

                    case 'z':
                        parole = File.ReadAllLines(@"z.txt");
                        break;
                    default:
                        {
                        }; break;
                }
            };
        }

        public int ricerca(string parola)
        {
            int i=0;
            trovato = false;
            do
            {
                if (parola_inserire == parole[i])
                    trovato = true;
                else
                    i++;
            } while (trovato==false && i < parole.Length);

            if (trovato == true)
                return 1;
            else
                return -1;    
        }

        public void ris()
        {
            int i = 0;
            int j = 0;
            int temp=0;

            //CONTROLLO LE PROLE CHE NON DEVO INSERIRE
            if (parola_inserire == "" || parola_inserire.ElementAt(0) == 'j' || parola_inserire.ElementAt(0) == 'k' || parola_inserire.ElementAt(0) == 'y')
                set_all("NOT FOUND");
            
            else
            {
                //ENTRA NEL CICLO E LEGGO LE PAROLE DI TUTTO IL FILE 
                do
                {
                    //SE IL NUMERO DELLE PAROLE E' SUPERIORE A 3
                    if (parole.Length > 3)
                    {
                        //CONTROLLO SULLA LUNGHEZZA DELLE DUE PAROLE 
                        if (parola_inserire.Length == parole.ElementAt(i).Length || parola_inserire.Length + 2 == parole.ElementAt(i).Length )
                        {
                            temp=parola_inserire.Length;

                            if (parola_inserire[temp - 1] == parole[i][temp - 1])
                                risultati[j] = parole[i];
                            j++;
                        }
                        else
                        {
                            set_r1(risultati.ElementAt(0));
                            set_r2(risultati.ElementAt(1));
                            set_r3(risultati.ElementAt(2));
                            i++;
                        }
                    }
                    else
                    {
                        if (parole.Length == 3)
                        {
                            set_r1(parole.ElementAt(0));
                            set_r2(parole.ElementAt(1));
                            set_r3(parole.ElementAt(2));
                        }
                        else if (parole.Length == 2)
                        {
                            set_r1(parole.ElementAt(0));
                            set_r2(parole.ElementAt(1));
                            set_r3("");
                        }
                        else if (parole.Length == 1)
                        {
                            set_r1(parole.ElementAt(0));
                            set_r2("");
                            set_r3("");
                        }
                        else
                        {
                            set_all("");
                        }
                        j = 3;
                    }

                } while (i < (parole.Length - 1) && j != 3 );
            }
        }

        private void set_all(string t)
        {
            set_r1(t);
            set_r2(t);
            set_r3(t);
        }

        private void set_r1(string r1)
        {
            risultati[0] = r1;
        }

        private void set_r2(string r1)
        {
            risultati[1] = r1;
        }

        private void set_r3(string r1)
        {
            risultati[2] = r1;
        }

        
        public string get_risultato1()
        {
            return risultati[0];
        }

        public string get_risultato2()
        {
            return risultati[1];
        }

        public string get_risultato3()
        {
            return risultati[2];
        }

        
        public void clear()
        {
            parola_inserire="";
            Array.Clear(risultati, 0, risultati.Length);
        }
         
    }
}
