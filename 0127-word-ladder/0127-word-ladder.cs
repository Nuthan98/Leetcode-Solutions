public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        var st = new HashSet<string>(wordList);

        if(!wordList.Contains(endWord))
            return 0;

        var queue = new Queue<(string, int)>();
        queue.Enqueue((beginWord,1));

        while(queue.Count > 0)
        {
            var (word, level) = queue.Dequeue();

            if(word == endWord)
                return level;

            for(int i = 0; i < word.Length; i++)
            {
                char[] wordArray = word.ToCharArray();

                for(char c = 'a'; c <= 'z'; c++)
                {
                    wordArray[i] = c;
                    var newWord = new string(wordArray);
                    if(st.Contains(newWord))
                    {
                        queue.Enqueue((newWord, level + 1));
                        st.Remove(newWord);
                    }
                }
            }
            level++;
        }
        return 0;
    }
}