class HelpForme
{
     public static string RetourDuneStringDansUnBloque (string message, int decalage = 0)
    {
           string boiteMessage = "";
           boiteMessage += RetourDuneStringDansUnBlock(message ,HelpForme.TrouvéLeBonDecalage(decalage,Help.StringToCharArray(message)));
           return boiteMessage;


    }

    private static string RetourDuneStringDansUnBlock (string message, int decalage = 0)
    {
        char[] charMessage = Help.StringToCharArray(message);
        string boiteMessage = "";

        boiteMessage += CreationDeDécalageSurString(decalage);

        boiteMessage += " ";
        boiteMessage += CreationDeDeLigne(charMessage.Length);

        boiteMessage += "\n";

        boiteMessage += CreationDeDécalageSurString(decalage);    

        boiteMessage +="| " + message + " |\n";
        
        boiteMessage += CreationDeDécalageSurString(decalage); 

        boiteMessage += " ";
        boiteMessage += CreationDeDeLigne(charMessage.Length);

        return boiteMessage; 
    }

    private static string CreationDeDécalageSurString (int decalage)
    {
        string boiteMessage ="";
        for(int i = 0; i<decalage; i++)
        {
             boiteMessage += " ";
        }
        return boiteMessage;
    }

    private static string CreationDeDeLigne (int charMessage)
    {
        string boiteMessage = "";
         for(int i = -2; i<charMessage; i++)
        {
            boiteMessage += "-";
        }
        return boiteMessage;
    }

    private static string PlacementDesMotsDansLesBoite (string[] message)
    {
        string boiteMessage = "| "; 
          for(int i = 0; i<message.Length; i++)
          {
              
              boiteMessage += message[i];
              boiteMessage += " | ";

          }
          
          return boiteMessage;
    }
    
    public static string RetourDuneStringDansUnTableauDeDeuxCase (string message1, string message2, int decalage = 0)
    {
            string boiteMessage = ""; 
            boiteMessage += RetourDuneStringDansUnTableauDeDeux(message1,message2, HelpForme.TrouvéLeBonDecalage(decalage,Help.StringToCharArray(message1 + message2)));
            return boiteMessage;
    }

    private static string RetourDuneStringDansUnTableauDeDeux (string message1, string message2, int decalage = 0)
    {
        if(decalage != 0)
        {
        decalage -= 2;
        }
        string[] messages = new string[2]{message1, message2};
        char[] charMessage1 = Help.StringToCharArray(message1);
        char[] charMessage2 = Help.StringToCharArray(message2);
        string boiteMessage = ""; 
        boiteMessage += CreationDeDécalageSurString(decalage);
        boiteMessage += " ";
        boiteMessage += CreationDeDeLigne(charMessage1.Length + charMessage2.Length + 3);
        boiteMessage += "\n";
        boiteMessage += CreationDeDécalageSurString(decalage);
        boiteMessage += PlacementDesMotsDansLesBoite (messages);
        boiteMessage += "\n";
        boiteMessage += CreationDeDécalageSurString(decalage);
        boiteMessage += " ";
        boiteMessage += CreationDeDeLigne(charMessage1.Length + charMessage2.Length+3);
        return boiteMessage;
    }

    private static int TrouvéLeBonDecalage (int reference, char[] charMessage)
    {
          int decalage = 0;
          if(charMessage.Length < reference)
          {
           
          decalage = (reference - charMessage.Length)/2;
          }

          return decalage;
    }

    public static string RetourDuneStringDansUnTableauSelonLeTableauDeStrings (string[] message, int decalage = 0)
    {
        string boiteMessage = "";
        boiteMessage +=RetourDuneStringDansUnTableauSelonLeTableauDeString(message, HelpForme.TrouvéLeBonDecalage( decalage ,Help.StringToCharArray(Help.MettreDesStringEnString(message))));
        return boiteMessage;
    }

     private static string RetourDuneStringDansUnTableauSelonLeTableauDeString (string[] message, int decalage = 0)
    {
        if(decalage != 0)
        {
        decalage -=(3 * (message.Length-1))/2;
        }
        int nombreDeChar = 0;
        for(int i = 0; i<message.Length; i++)
        {
            nombreDeChar += Help.AvoirLeNombreDeCharDansUneString(message[i]);
        }
         string boiteMessage = "";
         boiteMessage += CreationDeDécalageSurString(decalage);
         boiteMessage += " ";
         boiteMessage += CreationDeDeLigne(nombreDeChar + 3*(message.Length-1));
         boiteMessage += "\n";
         boiteMessage += CreationDeDécalageSurString(decalage);
         boiteMessage += PlacementDesMotsDansLesBoite (message);
         boiteMessage += "\n";
         boiteMessage += CreationDeDécalageSurString(decalage);
         boiteMessage += " ";
         boiteMessage += CreationDeDeLigne(nombreDeChar+3*(message.Length-1));


         return boiteMessage; 

    }

    
}