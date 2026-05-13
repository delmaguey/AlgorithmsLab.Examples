
public static class ContainerMostWater
{
    public static int Solve(int[] height) {

        int left=0;
        int right=height.Length-1;
        List<int> volumes = new List<int>();

        if(height.Length < 2)
            return 0;
        
        while(left<right)
        {
            int minLevel = Math.Min(height[left],height[right]);
            int size = right-left;
            int volume = minLevel*size;

            volumes.Add(volume);
            if(height[left] < height[right])
                left++;
            else
                right--;
        }

        return volumes.Max();
    }
}



