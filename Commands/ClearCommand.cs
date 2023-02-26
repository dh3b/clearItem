using CommandSystem;
using System;
using Exiled.API.Features;

namespace clearItem.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    class ClearCommand : ICommand
    {
        public string Command { get; } = "clearItem";
        public string[] Aliases { get; } = { "secureItem" };
        public string Description { get; } = "Usuń Przedmiot, który jest obecnie trzymany w ręce.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);

            if (sender is null)
            {
                response = "Aby użyć tej komendy musisz być graczem!";
                return false;
            }
            else
            {
                if (player.CurrentItem != null)
                { 
                    player.RemoveHeldItem(true);
                    response = "Przedmiot został usunięty.";
                    return true;
                }
                else
                {
                    response = "Aby użyć tej komendy musisz trzymać przedmiot w ręce!";
                    return false;
                }
            }
        }
    }
}
