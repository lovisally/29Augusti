// See https://aka.ms/new-console-template for more information
	Console.WriteLine("Är det fint väder?");
		string svar = Console.ReadLine();
		bool sant = svar == "ja"; 
		
		{
			if(sant)
			Console.WriteLine("gå ut!");
			
			else if(svar == "nej") 
			Console.WriteLine("stanna inomhus!");

            else(svar == "kanske")
            Console.WriteLine("jag förstår inte.");
	
		}
