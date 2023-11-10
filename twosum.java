/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

public class Main
{
  public static void main (String[]args)
  {
    System.out.println ("Starting...");
    twoSum (new int[]
	    {
	    2, 7, 11, 15}, 9);
    System.out.println ("***************");
    twoSum (new int[]
	    {
	    3, 2, 4}, 6);
    System.out.println ("***************");
    twoSum (new int[]
	    {
	    3, 3}, 6);
    System.out.println ("***************");
    twoSum (new int[]
	    {
	    2, 4, 11, 3}, 14);

  }
  public static int[] twoSum (int[]nums, int target)
  {
    int result[] = new int[2];
    result[0] = 0;
    result[1] = 0;
    int x;


    for (int i = 0; i <= nums.length - 1; i++)
      {
	for (int j = 0; j <= nums.length - 2; j++)
	  {
	    if (nums[i] + nums[j] == target)
	      {

		result[0] = j;
		result[1] = i;
		System.out.println (i + "  " + j);
		break;
	      }
	  }
      }
    return result;
  }
}
