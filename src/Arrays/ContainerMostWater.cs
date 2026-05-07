
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
            int maxLevel= Math.Min(height[left],height[right]);
            int size = right-left;
            int volume = maxLevel*size;

            volumes.Add(volume);
            left++;
        }

        return volumes.Max();
    }
}



