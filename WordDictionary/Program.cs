using System;
using System.Collections.Generic;

namespace WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new WordDictionaryClass();
            dict.AddWord("a");
            dict.AddWord("a");
            Console.WriteLine(dict.Search("aa"));
        }
    }

    public class WordDictionaryClass
    {
        TrieNode trie;

        public WordDictionaryClass()
        {
            trie = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode node = trie;
            foreach (var c in word.ToCharArray())
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children.Add(c, new TrieNode());
                }
                node = node.Children[c];
            }
            node.Word = true;
        }

        public bool Search(string word)
        {
            return SearchInNode(word, trie);
        }

        private bool SearchInNode(string word, TrieNode node)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if (!node.Children.ContainsKey(c))
                {
                    if (c == '.')
                    {
                        foreach (var key in node.Children.Keys)
                        {
                            TrieNode child = node.Children[key];
                            if (SearchInNode(word.Substring(i + 1), child))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    node = node.Children[c];
                }
            }
            return node.Word;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool Word = false;
        public TrieNode() { }
    }
}
