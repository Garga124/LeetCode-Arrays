/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf4);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
    public int Read(char[] buf, int n) {
             bool isEof = false;
            int charsRead = 0;
            char[] buf4 = new char[4];

            while (!isEof && charsRead < n) {
                int size = Read4(buf4);
                if (size < 4) {
                    isEof = true;
                }

                if (charsRead + size > n) {
                    size = n - charsRead;
                }

                /*
                        arraycopy(Object src,  int  srcPos,
                                  Object dest, int destPos,
                                  int length);
                 */
                // if last iteration and size==0, then copy length==0, not over-copy
               // System.arraycopy(buf4, 0, buf, charsRead, size);
                 Array.Copy(buf4, 0, buf, charsRead, size);
                charsRead += size;
            }

            return charsRead;
    }
      /* public class Reader4 {
        public int read4(char[] buf4) {
            return 1; // stub
        }
    }*/
}
