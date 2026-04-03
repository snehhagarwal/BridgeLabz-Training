using System.Collections.Generic;

public class MergeSorter
{
    // Merge sort logic
    public static List<Student> MergeSort(List<Student> students)
    {
        // Base case
        if (students.Count <= 1)
            return students;

        // Split list
        int mid = students.Count / 2;
        List<Student> left = students.GetRange(0, mid);
        List<Student> right = students.GetRange(mid, students.Count - mid);

        // Recursive sort
        left = MergeSort(left);
        right = MergeSort(right);

        // Merge result
        return Merge(left, right);
    }

    // Merge two sorted lists
    private static List<Student> Merge(List<Student> left, List<Student> right)
    {
        List<Student> result = new List<Student>();
        int i = 0, j = 0;

        // Compare elements
        while (i < left.Count && j < right.Count)
        {
            // Descending order
            if (left[i].Marks >= right[j].Marks)
                result.Add(left[i++]);
            else
                result.Add(right[j++]);
        }

        // Add remaining
        result.AddRange(left.GetRange(i, left.Count - i));
        result.AddRange(right.GetRange(j, right.Count - j));

        return result;
    }
}
