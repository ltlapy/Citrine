using System;
using System.Linq;
using System.Threading.Tasks;
using Citrine.Core.Api;

namespace Citrine.Core.Modules
{
	// public class VoteModule : ModuleBase
	// {
	//     Random rnd = new Random();
	//     public override async Task<bool> OnTimelineAsync(IPost n, IShell shell, Server core)
	//     {
	//         if (n?.Poll == null)
	//             return false;

	//         if (n.User.Id == shell.Myself.Id)
	//             return false;

	//         // ランダムで投票する
	//         await shell.VoteAsync(n, rnd.Next(n.Poll.Choices.Count()));

	//         // 多分競合しないから常にfalse
	//         return false;
	//     }
	// }
}
