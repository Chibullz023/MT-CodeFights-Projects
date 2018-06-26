// Checks String to see if it is a Palindrome (String which reads the same left-right and right-left)

// An example of a Palindrome would be aabaa

bool checkPalindrome(string inputString) {
        string first = inputString.Substring(0, inputString.Length / 2);
        char[] arr = inputString.ToCharArray();
        Array.Reverse(arr);
        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);
        return first.Equals(second);
}