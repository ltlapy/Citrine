#pragma warning disable CS1998 // 비동기 메서드는 'await' 연산자가 없기 때문에 동기적으로 실행됩니다
using System;
using System.Threading.Tasks;
using System.Web;
using BotBone.Core;
using BotBone.Core.Api;
using BotBone.Core.Modules;
using Newtonsoft.Json.Linq;

namespace Citrine.Core
{
	public class NmoudameCommand : CommandBase
	{
		public override string Name => "nmoudame";

		public override string Usage => "/nmoudame";

		public override string[] Aliases => new[] { "nmudm" };

		public override string Description => "テェエッキイ…ィ！ス…ウゥットオ…ォッ！を…ぉぉっ変…っ換……！し…ぃいぃ！て………っ返……し…ぃいい…まあ…っ！す…ぅっ！。 (일본어 전용)";

		public override async Task<string> OnActivatedAsync(ICommandSender sender, Server core, IShell shell, string[] args, string body)
		{
			try
			{
				return JObject.Parse(await (await Server.Http.GetAsync(GetEndpoint(body))).Content.ReadAsStringAsync())["result"].Value<string>();
			}
			catch (Exception ex)
			{
				logger.Error($"{ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
				return "エラー";
			}
		}
		private readonly Logger logger = new Logger(nameof(NmoudameCommand));

		private static string GetEndpoint(string text) => $"http://tekito.kanichat.com/nmoudame/response.php?str={HttpUtility.UrlEncode(text)}&mode=json&length=6&normal=1&small=1&dots=1&ltu_prob=30&ex_prob=30&c=0";
	}
}
