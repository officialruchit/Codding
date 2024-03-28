import java.util.*;

class HelloWorld {
    public static void fre(int[] arr, int n) {
        HashMap<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < n; i++) {

            if (map.containsKey(arr[i])) {
                map.put(arr[i], map.get(arr[i]) + 1);
            } else {
                map.put(arr[i], 1);
            }
        }
        System.out.println(map);

    }

    public static void main(String[] args) {
        System.out.println("Try programiz.pro");
        int[] arr = { 2, 2, 3, 4, 5 };
        int n = arr.length;
        fre(arr, n);
    }
}
