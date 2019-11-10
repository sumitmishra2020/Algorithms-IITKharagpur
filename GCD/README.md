https://en.wikipedia.org/wiki/Euclidean_algorithm

Problem


Solutions
C
C++
Java
Python3
C
    #include <stdio.h>

    typedef size_t Type;

    Type gcd( Type a, Type b ){
        for( Type t = 0; b != 0; ){
            t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    int main(){
        Type a = 0,
             b = 0;
        scanf( "%ld %ld", &a, &b );
        Type ans = gcd( a, b );
        printf( "%ld\n", ans );
        return 0;
    }
CPP
    #include <iostream>

    using namespace std;

    template< typename Type >
    class Solution {
    public:
        Type gcd( Type a, Type b ){
            for( auto t{ b }; b != 0; ){
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    };

    int main(){
        using Type = size_t;
        Solution< Type > solution;
        Type a = 0,
             b = 0;
        cin >> a >> b;
        Type ans = solution.gcd( a, b );
        cout << ans << endl;
        return 0;
    }
Java
    import java.util.Scanner;

    public class Main {

        private static int gcd( int a, int b ){
            for( int t = 0; b != 0; ){
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static void main(String[] args){
            Scanner input = new Scanner( System.in );
            int a = input.nextInt(),
                b = input.nextInt(),
                ans = gcd( a, b );
            System.out.println( ans );
        }
    }
Python3
    def gcd( a, b ):
        while b != 0:
            t = b
            b = a % b
            a = t
        return a

    if __name__ == '__main__':
        a, b = map( int, input().split() )
        ans = gcd( a, b )
        print( ans )
