using System.Threading;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;

namespace HonzaBotner.Discord.Command
{
    public interface IChatCommand
    {
        Task Execute(DiscordClient client, DiscordMessage message, CancellationToken cancellationToken);
    }
}