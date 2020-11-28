using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Brady_s_Son_Bot
{
    public class Commands : ModuleBase
    {
        Random rdm = new Random();

        [Command("help"), Summary("Displays commands and information about topics.")]
        public async Task Help(string topic = null)
        {
            await ReplyAsync("hi theres literally no commands yet oh wait except for one:\nsay `kek suggest [ur suggestion]` for command ideas");
        }

        [Command("suggest"), Summary("Suggest new commands for the bot.")]
        public async Task Suggest([Remainder] string suggestion)
        {
            Console.WriteLine(suggestion);
            string xtra = "";
            if (suggestion.StartsWith("[") && suggestion.EndsWith("]"))
            {
                xtra = " lol you dont need the brackets but anyway";
                suggestion = suggestion.Trim('[', ']');
            }
            await ReplyAsync($"hey thanks for ur suggestion{xtra} ill tell brady\n\nhey <@{Constants.Users.BRADY}>, {Context.User.Username} says: ```{suggestion}```");
        }
    }
}
