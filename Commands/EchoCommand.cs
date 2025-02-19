#pragma warning disable CS1998 // 비동기 메서드는 'await' 연산자가 없기 때문에 동기적으로 실행됩니다
using System.Threading.Tasks;
using BotBone.Core;
using BotBone.Core.Api;
using BotBone.Core.Modules;

namespace Citrine.Core
{
	public class EchoCommand : CommandBase
	{
		public override string Name => "echo";

		public override string Usage => "/echo <text>";

		public override string Description => "문자열을 그대로 출력합니다.";

		public override async Task<string> OnActivatedAsync(ICommandSender sender, Server core, IShell shell, string[] args, string body)
		{
			return body;
		}
	}
}
