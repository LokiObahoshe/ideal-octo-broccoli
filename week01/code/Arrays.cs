public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array for the results using double so that it can hold decimals and give it a length
        double[] result = new double[length];

        // Use a loop that will repeatingly display the results
        for (int i = 0; i < length; i++)
        {
            // Shift the index up using a number (or do the math, in otherwords). For example, 3(<--number) * (1(<--index)+1) = 6
            result[i] = number * (i + 1);
        }

        // Use a return for results
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Check if the list is empty. If not, then don't continue (use a return)
        if (data == null || data.Count == 0)
        {
            return;
        }

        // Create the list, but seperate it into two lists so that the rotation is possible
        List<int> suffixPart = data.GetRange(data.Count - amount, amount);
        List<int> prefixPart = data.GetRange(0, data.Count - amount);

        // Clear the lists and rebuild them
        data.Clear();
        data.AddRange(suffixPart);
        data.AddRange(prefixPart);
    }
}
