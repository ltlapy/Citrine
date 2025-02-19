using System;
using System.Threading.Tasks;
using BotBone.Core;
using BotBone.Core.Api;
using BotBone.Core.Modules;

namespace Citrine.Core
{
	public class StopCommand : CommandBase
	{
		public override string Name => "stop";

		public override string Usage => "/stop";

		public override PermissionFlag Permission => PermissionFlag.AdminOnly;

		public override string Description => "Citrine을 끝냅니다.";

		public override async Task<string> OnActivatedAsync(ICommandSender sender, Server core, IShell shell, string[] args, string body)
		{
			if (sender is PostCommandSender s)
				await shell.ReplyAsync(s.Post, "다음에 또 봐요!");
			Environment.Exit(0);
			return null;
		}
	}
}
