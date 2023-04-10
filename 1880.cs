public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        int firstconverted = convert(firstWord);
        //Console.WriteLine("first word: " + firstconverted);
        
        int secondconverted = convert(secondWord);
        //Console.WriteLine("second word: " + secondconverted);
        
        int lastconverted = convert(targetWord);
        //Console.WriteLine("last word: " + lastconverted +"\n");
        
        return firstconverted + secondconverted == lastconverted;
    }
    
    public int convert(string word){
        string converted = "";
        foreach(var c in word){
            //Console.WriteLine(word[i]-'a');
            converted += (c-'a');
        }
        //Console.WriteLine("converted: "+converted);
        return Int32.Parse(converted);
    }
}
