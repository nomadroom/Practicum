﻿namespace L.S.D.Message.LastMessageToEndGame
{
    internal class TheEnd
    {
        public static async void SendLastMessageInGame()
        {
            var lastMessage = @"      _____                    _____                    _____              
     /\    \                  /\    \                  /\    \             
    /::\    \                /::\____\                /::\    \            
    \:::\    \              /:::/    /               /::::\    \           
     \:::\    \            /:::/    /               /::::::\    \          
      \:::\    \          /:::/    /               /:::/\:::\    \         
       \:::\    \        /:::/____/               /:::/__\:::\    \        
       /::::\    \      /::::\    \              /::::\   \:::\    \       
      /::::::\    \    /::::::\    \   _____    /::::::\   \:::\    \      
     /:::/\:::\    \  /:::/\:::\    \ /\    \  /:::/\:::\   \:::\    \     
    /:::/  \:::\____\/:::/  \:::\    /::\____\/:::/__\:::\   \:::\____\    
   /:::/    \::/    /\::/    \:::\  /:::/    /\:::\   \:::\   \::/    /    
  /:::/    / \/____/  \/____/ \:::\/:::/    /  \:::\   \:::\   \/____/     
 /:::/    /                    \::::::/    /    \:::\   \:::\    \         
/:::/    /                      \::::/    /      \:::\   \:::\____\        
\::/    /                       /:::/    /        \:::\   \::/    /        
 \/____/                       /:::/    /          \:::\   \/____/         
                              /:::/    /            \:::\    \             
                             /:::/    /              \:::\____\            
                             \::/    /                \::/    /            
                              \/____/                  \/____/             
                                                                           
          _____                    _____                    _____          
         /\    \                  /\    \                  /\    \         
        /::\    \                /::\____\                /::\    \        
       /::::\    \              /::::|   |               /::::\    \       
      /::::::\    \            /:::::|   |              /::::::\    \      
     /:::/\:::\    \          /::::::|   |             /:::/\:::\    \     
    /:::/__\:::\    \        /:::/|::|   |            /:::/  \:::\    \    
   /::::\   \:::\    \      /:::/ |::|   |           /:::/    \:::\    \   
  /::::::\   \:::\    \    /:::/  |::|   | _____    /:::/    / \:::\    \  
 /:::/\:::\   \:::\    \  /:::/   |::|   |/\    \  /:::/    /   \:::\ ___\ 
/:::/__\:::\   \:::\____\/:: /    |::|   /::\____\/:::/____/     \:::|    |
\:::\   \:::\   \::/    /\::/    /|::|  /:::/    /\:::\    \     /:::|____|
 \:::\   \:::\   \/____/  \/____/ |::| /:::/    /  \:::\    \   /:::/    / 
  \:::\   \:::\    \              |::|/:::/    /    \:::\    \ /:::/    /  
   \:::\   \:::\____\             |::::::/    /      \:::\    /:::/    /   
    \:::\   \::/    /             |:::::/    /        \:::\  /:::/    /    
     \:::\   \/____/              |::::/    /          \:::\/:::/    /     
      \:::\    \                  /:::/    /            \::::::/    /      
       \:::\____\                /:::/    /              \::::/    /       
        \::/    /                \::/    /                \::/____/        
         \/____/                  \/____/                  ~~              ";


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(lastMessage.ToString());
        }
    }
}
