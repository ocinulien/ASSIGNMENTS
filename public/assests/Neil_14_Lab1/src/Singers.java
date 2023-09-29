public class Singers {
    int ID;
    String singerName;
    String address;
    String DOB;
    int albumsPublished;

    public Singers() {
        this.ID = 12345;
        this.singerName = "Danna";
        this.address = "Toronto";
        this.DOB = "July 31, 1997";
        this.albumsPublished = 2;

    }

    public Singers(int ID) {
        this.ID = ID;
        this.singerName = "Nick";
        this.address = "Vaughn";
        this.DOB = "October 1, 1997";
        this.albumsPublished = 3;
    }

    public Singers(int ID, String name) {
        this.ID = ID;
        this.singerName = name;
        this.address = "Ajax";
        this.DOB = "September 5, 1997";
        this.albumsPublished = 5;
    }

    public Singers(int ID, String name, String address) {
        this.ID = ID;
        this.singerName = name;
        this.address = address;
        this.DOB = "December 5, 1997";
        this.albumsPublished = 6;
    }

    public Singers(int ID, String name, String address, String DOB) {
        this.ID = ID;
        this.singerName = name;
        this.address = address;
        this.DOB = DOB;
        this.albumsPublished = 7;
    }

    public Singers(int ID, String name, String address, String DOB, int alPub) {
        this.ID = ID;
        this.singerName = name;
        this.address = address;
        this.DOB = DOB;
        this.albumsPublished = alPub;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public void setSingerName(String singerName){
        this.singerName = singerName;
    }

    public void setAddress(String address){
        this.address = address;
    }

    public void setDOB (String DOB) {
        this.DOB = DOB;
    }

    public void setAlbumsPublished (int albumsPublished){
        this.albumsPublished = albumsPublished;
    }

    public void setSinger(int ID, String singerName, String address, String DOB, int albumsPublished){
        this.ID = ID;
        this.singerName = singerName;
        this.address = address;
        this.DOB = DOB;
        this.albumsPublished = albumsPublished;
    }

    public int getID() {
        return this.ID;
    }

    public String getSingerName() {
        return this.singerName;
    }

    public String getAddress() {
        return this.address;
    }

    public String DOB() {
        return this.DOB;
    }

    public int getAlbumsPublished() {
        return this.albumsPublished;
    }

    @Override
    public String toString() {
        return ("Singer ID: " + ID +
                "\nSinger name: " + singerName + "\nSinger Address: " + address +
                "\nDOB: " + DOB + "\nand # of albums published: " + albumsPublished);
    }
}
