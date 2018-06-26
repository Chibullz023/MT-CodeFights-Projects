int centuryFromYear(int year) {
	// Returns the year - 1 and divided by 100 +1
    return ((year - 1) / 100) + 1;
	
	// example: 1905 - 1 = 1904 / 100 = 19.04 + 1 = 20.04 or the 20th Century
}