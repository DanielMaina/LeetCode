/**
Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.

Notice that you may not slant the container.
**/
/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
    // Max amountof water
    let max = 0
    // Pointer to move possible heights
    let left = 0
    let right = height.length-1
    // Use 2 pointers to find the max area
    while(left < right) {
        // Current area
        const area = Math.min(height[left], height[right]) * (right - left)
        // Check if current area is greater than previous max
        max = Math.max(max, area)
        // Move the pointer that has the lowest height
        if(height[left]>height[right]) {
            right--
        } else {
            left++
        }
    }
    return max
};