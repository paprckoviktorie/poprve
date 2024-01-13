using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLeden
{
    internal class Program
    {
        class Alex
        {
            public string hairColor;
            public int age;
            public string city;

            public Alex(string hairColor, int age, string city)
            {
                this.hairColor = hairColor;
                this.age = age;
                this.city = city;
            }

            public void UserInputAlex()
            {
                Console.WriteLine("Je Alex blondýna, bruneta nebo zrzka?");
                this.hairColor = Console.ReadLine();
                Console.Write('\n');

                Console.WriteLine("Kolik je Alex?");
                this.age = int.Parse(Console.ReadLine());
                Console.Write('\n');

                Console.WriteLine("Má se stěhovat do města 'Velikánov' nebo 'Ohromňákov'?");
                this.city = Console.ReadLine();
                Console.Write('\n');


            }
        }
        class Decisions
        {
            public string studyWork;
            public string wrongAnswer;

            public Decisions(string studyWork, string wrongAnswer)
            {
                this.studyWork = studyWork;
                this.wrongAnswer = wrongAnswer;
            }

            public void UserInputStudyWork()
            {
                Console.WriteLine($"Alex se rozhoduje, jestli ve městě nastoupí na její vysněnou školu psychologie nebo začne pracovat v malebné kavárničce nedaleko jejího nového bydliště. V Malíkově totiž žádnou kavárnu neměla. Co myslíš, má jít 'pracovat' nebo 'studovat'?");
                this.studyWork = Console.ReadLine();
            }

            public void WrongUserInput()
            {
                Console.WriteLine("Promiň, ale asi tam máš nějakou chybu. Nemůžu Tvou odpověď přiřadit žádnému programu. Zkus to znovu.");
                this.wrongAnswer = Console.ReadLine();
            }
        }

        class Work
        {
            public string date;
            public string afterDate;
            public string datePositive;
            public string dateNegative;

            public Work(string date, string afterDate, string datePositive, string dateNegative)
            {
                this.date = date;
                this.afterDate = afterDate;
                this.datePositive = datePositive;
                this.dateNegative = dateNegative;
            }

            public void UserInputDate()
            {
                Console.WriteLine("Alex hned po příjezdu absolvovala baristický kurz, aby mohla začít pracovat v kavárně, do které nastoupila. Než její latté art bude dokonalý, to chvíli potrvá, ale učí se rychle a moc ji to baví.");
                Console.ReadLine();
                Console.Write('\n');

                Console.WriteLine("Kdo Alex v poslední době hodně leží v hlavě, je stálý zákazník Lukáš. Často po sobě pokukují. Právě Alex oslovil a ptá se, zda by ji mohl pozvat na večeři. Myslíš, že by 'měla' nebo 'neměla' jít?");
                this.date = Console.ReadLine();
            }

            public void UserInputAfterDate()
            {
                Console.WriteLine("Rande bylo milé, dobře si rozuměli, ale jiskra nepřeskočila. Přemýšlí, zda to zkusit 'znovu' nebo se jen budou 'kamarádit'.");
                this.afterDate = Console.ReadLine();
            }
            public void DatePositive()
            {

                Console.WriteLine("Alex Lukášovi dává další šanci, chce ho více poznat, než udělá další rozhodnutí.");
                Console.ReadLine();
                Console.WriteLine("Čím více se poznávají, tím více si jsou sympatičtí. Sbližují se, začínají spolu chodit.");
                Console.ReadLine();
                Console.WriteLine("Po pár měsících přemýšlejí, zda se sestěhovat a zložit 'rodinu' nebo se sbalit a začít 'cestovat'. Co jim radíš Ty?");
                this.datePositive = Console.ReadLine();
            }

            public void DateNegative()
            {
                Console.WriteLine("Alex si ale spokojeně pracuje v kavárně dál, zlepšuje se v přípravě kávy a má více a více přátel.");
                this.dateNegative = Console.ReadLine();
            }
                
        }

        class Study
        {
            public string living;
            public string liveAlone;
            public string liveOnCampus;
            public string internship;
            public string stayAtHome;
            public string seaCity;
            public string slovakia;
            public string yoga;
            public string theodor;

            public Study (string living, string liveAlone, string liveOnCampus, string internship, string stayAtHome, string seaCity, string slovakia, string yoga,string theodor)
            {
                this.living = living;
                this.liveAlone = liveAlone;
                this.liveOnCampus = liveOnCampus;
                this.internship = internship;
                this.stayAtHome = stayAtHome;
                this.seaCity = seaCity;
                this.slovakia = slovakia;
                this.yoga = yoga;
                this.theodor = theodor;
            }

            public void UserDecisionLiving()
            {
                Console.WriteLine("Po nástupu do školy dostala možnost, přestěhovat se na 'kolej' nebo 'zůstat' bydlet sama. Co myslíš, že je pro studentský život lepší?");
                this.living = Console.ReadLine();
            }
            public void Alone()
            {
                Console.WriteLine("Na konec Alex stále bydlí sama. Říkala si, že je škoda se stěhovat, když už za pár let stejně nebude student školy. Holt to bude muset finančně zvládnout.");
                Console.ReadLine();
                Console.WriteLine("Co jí ale chybí, je sociální život. Kamarádi. Na přednáškách jich ještě mnoho nepotkala a přemýšlí, zda je na to lepší školní 'kavárna' nebo 'kurz' jógy, kde by se zase seznámila s jiným typem lidí.");
                this.liveAlone = Console.ReadLine();
            }

            public void Campus()
            {
                Console.WriteLine("Začala mnohem více poznávat spolužáky, se kterými chodila na různé akce, mimoškolní přednášky a učila se s nimi.");
                Console.ReadLine();
                Console.WriteLine("Společné učení ji velmi posunulo a začala dosahovat skvělých studijních výsledků. Dostala možnost přijmout pracovní stáž v zahraničí. Nyní přemýšlí, zda 'jet' nebo 'nejet'.");
                this.liveOnCampus= Console.ReadLine();
            }

            public void Internship()
            {
                Console.WriteLine("Taková příležitost se neodmítá, a tak se Alex balí na tříměsíční stáž.");
                Console.ReadLine();
                Console.WriteLine("Akorát se nemůže rozhodnout. Nabízí se 'Slovensko', 'Portugalsko', 'Španělsko'.");
                this.internship = Console.ReadLine();
            }

            public void StayAtHome()
            {
                Console.WriteLine("Není si jista, jestli by ji to v zahraničí bavilo, v Česku je přeci jen doma a cítí se tu nejlépe.");
                this.stayAtHome= Console.ReadLine();
            }

            public void SeaCities()
            {
                Console.WriteLine($"Nakonec u Alex zvítězilo {this.internship}. Chtěla někam, kde je teplo a bude se mezi učením a prací chodit koupat do moře.");
                Console.ReadLine();
                Console.WriteLine("Poznává novou kulturu, nové, často temperamentní, lidi, užívá se Sluníčka a ani neví jak, ale blíží se den odjezdu. Vůbec se jí ale pryč nechce... Má se 'vrátit' domů, do Česka nebo 'přestěhovat' se a přestoupit na místní školu práv?");
                this.seaCity= Console.ReadLine();
            }

            public void Slovakia()
            {
                Console.Write("Alex nechtěla jet moc daleko, aby byla blízko rodině, a tak se rozhodla jet na Slovensko.");
                Console.ReadLine();
                Console.WriteLine("Ač je teprve studentka práv, velice se jí ve slovenské firmě dařilo a nabízeli ji pevnou pozici u nich ve firmě. Alex ale pořád cítí potřebu, jet 'domů', ikdyž ji pracovní 'místo' láká.");
                this.slovakia = Console.ReadLine();
            }

            public void Yoga()
            {
                Console.WriteLine("Možná je rozumnější, seznamovat se s lidmi i jinde, než ve škole a právě vypsali kurz jógy, tak se na něj Alex přihlásila.");
                Console.ReadLine();
                Console.WriteLine("Hned na první lekci ji zaujal vysoký klidný muž se středně dlouhými vlasy. Dle toho, jak jej instruktorka oslovovala, se jmenoval Theodor. Byl jeden ze tří mužů, docházející na tento kurz. Pravděpodobně si Alex nevšiml, a tak se rozhodla, že za ním později 'půjde'. Nebo se má 'soustředit' jenom na školu a nemotat si hlavu?");
                this.yoga = Console.ReadLine();
            }

            public void Theodor()
            {
                Console.WriteLine("Na to, aby to mohla nechat jen tak, tak ji až moc zajímal a přitahoval. Oslovila ho a on s úsměvem přistoupil na rande v čajovně.");
                Console.ReadLine();
                Console.WriteLine("Už po prvním setkání měla Alex motýlky v břiše a cítila, jak moc si s Theodorem rozumí.");
                Console.ReadLine();
                Console.WriteLine("Dokonce až tak moc, že zatoužila založit 'rodinu'. Ale zároveň už byla blízko k tomu, 'dokončit' školu. Potřebuje poradit.");
                this.theodor = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, vítej u nové Role Play hry, kde právě ty rozhodneš o osudu naší hrdinky Alex. Upozorňuji, že u některých rozhodnutí bude potřeba zadat přesný formát. Pokud se tak stane, budou možnost napsány v jednoduchých uvozovkách (''). No ale teď už k Alex.");
            Console.ReadLine();

            Console.WriteLine("Alex se narodila v malém městě Malíkově, kde i ukončila studium na místním gymnáziu. Nyní, po pár letech se stěhuje buď do Velikánova nebo do Ohromňákova, jelikož ji to vždy lákalo. Pojď vytvořit postavu Alex:");
            Console.ReadLine();

            Alex alex = new Alex("defaultColor",0,"defaultCity");
            alex.UserInputAlex();
            Console.WriteLine($"Alex tedy bude {alex.hairColor}, bude jí {alex.age} let, přestěhuje se do města {alex.city}.");
            Console.ReadLine();

            Decisions studywork = new Decisions(default(string), default(string));
            studywork.UserInputStudyWork();
            Console.WriteLine($"Dobře, bylo rozhodnuto, že Alex bude {studywork.studyWork}.");
            Console.ReadLine();

        
            if (studywork.studyWork == "pracovat")//Příběh, pokud uživatel zvolil, že Alex bude pracovat.
            {
                Work work = new Work(default(string), default(string), default(string), default(string));
                work.UserInputDate();

                if (work.date == "měla")
                {
                    Console.WriteLine("Lukáš na Alex počkal a po směně se spolu vydali do nové italské restaurace");
                    work.UserInputAfterDate();

                    if (work.afterDate == "znovu")
                    {
                        work.DatePositive();

                        if (work.datePositive == "cestovat")
                        {
                            Console.WriteLine("Vzhledem k tomu, že jsou mladí a bez závazků, tak se rozhodli procestovat Evropu.");
                            Console.ReadLine();
                        }
                        else if (work.datePositive =="rodinu")
                        {
                            Console.WriteLine("Našli krásný velký byt u místního parku, narodí se jim první syn a po něm postupně další tři děti.");
                            Console.ReadLine();
                        }
                        else
                        {
                            studywork.WrongUserInput();
                        }
                    }
                    else if (work.afterDate =="kamarádit")
                    {
                        Console.WriteLine("Díky Alex se rozhodli, že zůstanou kamarády, jelikož se jim dobře povídá.");
                        work.DateNegative();
                    }
                    else
                    {
                        studywork.WrongUserInput();
                    }
                }
                else if (work.date=="neměla")
                {
                    Console.WriteLine("Bohužel Lukáš odmítnutí nevzal moc dobře, a tak se v kavárně, když měla směnu Alex, už neukázal.");
                    work.DateNegative();
                }
                else
                {
                    studywork.WrongUserInput();
                }
            }


            else if (studywork.studyWork =="studovat") //Zde je příběh a jeho možnosti, zvolil-li uživatel možnost, že Alex bude studovat.
            {
                Console.WriteLine("Alex úspěšně absolvovala přijímačky i pohovor, na její vysněnou školu ji vzali a nyní si spokojeně studuje. Občas je to náročné, ale stojí to za to. Těší se, až bude pomáhat lidem.");
                Console.ReadLine();
                Study study = new Study(default(string), default(string), default(string), default(string), default(string), default(string), default(string), default(string), default(string));
                study.UserDecisionLiving();

                if (study.living == "kolej")
                {
                    Console.WriteLine("Kolej Alex pomohla. A to nejen finančně (přeci jen je to zlomek ceny celého bytu), ale i sociálně.");
                    Console.ReadLine();
                    study.Campus();

                    if (study.liveOnCampus == "jet")
                    {
                        study.Internship();

                        if (study.internship == "Španělsko" || study.internship == "Portugalsko")
                        {
                            study.SeaCities();

                            if (study.seaCity == "přestěhovat")
                            {
                                Console.WriteLine($"{study.internship} si tak zamilovala, že tam nakonec zůstala. Už se může každý den do konce života koupat v nádherném modrém moři.");
                                Console.ReadLine();
                            }
                            else if (study.seaCity == "vrátit")
                            {
                                study.StayAtHome();
                            }
                            else
                            {
                                studywork.WrongUserInput();
                            }
                        }
                        else if (study.internship == "Slovensko")
                        {
                            study.Slovakia();
                            if (study.slovakia == "domů")
                            {
                                study.StayAtHome();
                            }
                            else if (study.slovakia == "místo")
                            {
                                Console.WriteLine("Touha po dobře placené pracovní pozici ji přemohla a na Slovensku zůstala. Přeci jen to není tak daleko od domova.");
                                Console.ReadLine();
                            }
                            else
                            {
                                studywork.WrongUserInput();
                            }
                        }
                        else
                        {
                            studywork.WrongUserInput();
                        }
                    }
                    else if (study.liveOnCampus == "nejet")
                    {
                        study.StayAtHome();
                    }
                    else
                    {
                        studywork.WrongUserInput();
                    }
                }
                else if (study.living == "zůstat")
                {
                    study.Alone();

                    if (study.liveAlone == "kavárna")
                    {
                        Console.WriteLine("Vzhledem k tomu, že na škole nebude vččně, začala chodit do studentské kavárny, aby se seznámila s ostatními.");
                        Console.ReadLine();
                        study.Campus(); //Tady pro Alex příběh skončí stejně, jako kdyby se tehda přestěhovala na kolej.
                        if (study.liveOnCampus == "jet")//Odsud zkopírovaný kód
                        {
                            study.Internship();

                            if (study.internship == "Španělsko" || study.internship == "Portugalsko")
                            {
                                study.SeaCities();

                                if (study.seaCity == "přestěhovat")
                                {
                                    Console.WriteLine($"{study.internship} si tak zamilovala, že tam nakonec zůstala. Už se může každý den do konce života koupat v nádherném modrém moři.");
                                    Console.ReadLine();
                                }
                                else if (study.seaCity == "vrátit")
                                {
                                    study.StayAtHome();
                                }
                                else
                                {
                                    studywork.WrongUserInput();
                                }
                            }
                            else if (study.internship == "Slovensko")
                            {
                                study.Slovakia();
                                if (study.slovakia == "domů")
                                {
                                    study.StayAtHome();
                                }
                                else if (study.slovakia == "místo")
                                {
                                    Console.WriteLine("Touha po dobře placené pracovní pozici ji přemohla a na Slovensku zůstala. Přeci jen to není tak daleko od domova.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    studywork.WrongUserInput();
                                }
                            }
                            else
                            {
                                studywork.WrongUserInput();
                            }
                        }
                    }//Posud zkopírovaný kód.
                    else if (study.liveAlone == "kurz")
                    {
                        study.Yoga();

                        if (study.yoga == "půjde")
                        {
                            study.Theodor();

                            if (study.theodor == "rodinu")
                            {
                                Console.WriteLine("Její láska k Theodorovi byla tak obrovská, že nechala studií, přestěhovala se s ním do maringotky a měli spolu spoustu dětí.");
                                Console.ReadLine();
                            }
                            else if (study.theodor == "dokončit")
                            {
                                Console.WriteLine("Naštěstí ji popadl rozum a rozhodla se školu dodělat a s Theodorem se vídat ve volných chvílích a na józe.");
                                Console.ReadLine();
                            }
                            else
                            {
                                studywork.WrongUserInput();
                            }
                        }
                        else if (study.yoga == "soustředit") //I zde pro ni opět bude stejný osud, jako by byl ve dvou případech výše.
                        {
                            Console.WriteLine("Práva nejsou lehký obor a motat si zbytečně hlavu, by nebylo dobré k ničemu.");
                            Console.ReadLine();
                            study.Campus();
                            if (study.liveOnCampus == "jet")
                            {
                                study.Internship();

                                if (study.internship == "Španělsko" || study.internship == "Portugalsko")
                                {
                                    study.SeaCities();

                                    if (study.seaCity == "přestěhovat")
                                    {
                                        Console.WriteLine($"{study.internship} si tak zamilovala, že tam nakonec zůstala. Už se může každý den do konce života koupat v nádherném modrém moři.");
                                        Console.ReadLine();
                                    }
                                    else if (study.seaCity == "vrátit")
                                    {
                                        study.StayAtHome();
                                    }
                                    else
                                    {
                                        studywork.WrongUserInput();
                                    }
                                }
                                else if (study.internship == "Slovensko")
                                {
                                    study.Slovakia();
                                    if (study.slovakia == "domů")
                                    {
                                        study.StayAtHome();
                                    }
                                    else if (study.slovakia == "místo")
                                    {
                                        Console.WriteLine("Touha po dobře placené pracovní pozici ji přemohla a na Slovensku zůstala. Přeci jen to není tak daleko od domova.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        studywork.WrongUserInput();
                                    }
                                }
                                else
                                {
                                    studywork.WrongUserInput();
                                }
                            }//Končí to zde.
                        }
                        else
                        {
                            studywork.WrongUserInput();
                        }
                    }
                    else
                    { 
                        studywork.WrongUserInput();
                    }
                }
                else
                {
                    studywork.WrongUserInput();
                }
            }
            else
            {
                studywork.WrongUserInput();
            }



        }
    }
}
