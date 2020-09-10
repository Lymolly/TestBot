using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Services
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task Sheva()
        {
            var user = Context.User.Id;
            if (user == 292613626878230528)
            {
                var user2 = Context.User;
                await ReplyAsync($"[{user2.Username}], пошел нахуй, долбоеб!");
            }
        }
    }
}
