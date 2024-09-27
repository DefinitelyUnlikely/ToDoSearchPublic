public class StopCommand {
    public static void Execute(string[] commandArgs) {
        Program.running = false;
    }
}