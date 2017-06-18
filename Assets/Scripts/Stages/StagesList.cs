namespace Masaya64.Controller{
	public static class StagesList{
		public enum stages 
		{
			stage_select 	= 0,
			stage			= 1,
			result			= 2
		}
		private static string[] stage_name = new string[] 
		{
			"StageSelect",
			"Stage",
			"Result"
		};
		public static string getStageName(stages stage){
			return stage_name [(int)stage];
		}
	}
}