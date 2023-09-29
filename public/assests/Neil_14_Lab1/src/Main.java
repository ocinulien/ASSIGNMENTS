// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        // Press Alt+Enter with your caret at the highlighted text to see how
        // IntelliJ IDEA suggests fixing it.
        System.out.printf("Neil Unico/Section: 14/Lab 1");

        testSinger();
    }//main ends

    static void testSinger(){

        Singers singer1 = new Singers();
        System.out.println("\nsinger 1: " + singer1);

        singer1.setID(23415);
        System.out.println("\nsinger 1: " + singer1);

        singer1.setSingerName("Justin");
        System.out.println("\nsinger 1: " + singer1);

        singer1.setAddress("Pickering");
        System.out.println("\nsinger 1: " + singer1);

        singer1.setDOB("June 9, 2003");
        System.out.println("\nsinger 1: " + singer1);

        singer1.setAlbumsPublished(100);
        System.out.println("\nsinger 1: " + singer1);

        singer1.setSinger (54321, "Danica", "North York", "January 27, 2004", 10);
        System.out.println("\nsinger 1: " + singer1);

        Singers singer2 = new Singers(67890);
        System.out.println("\nsinger 2: " + singer2);

        Singers singer3 = new Singers(19876, "Danzel");
        System.out.println("\nsinger 3: " + singer3);




    }
}