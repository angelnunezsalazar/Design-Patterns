package duck;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class DecoyDuckTests {
    private Duck duck;

    @Before
    public void Setup()
    {
        duck= new DecoyDuck();
    }

    @Test
    public void cantFly()
    {
        assertEquals(DuckMessages.CantFly,duck.fly());
    }

    @Test
    public void squeak()
    {
        assertEquals(DuckMessages.Silence, duck.quack());
    }


    @Test
    public void display()
    {
        assertEquals(DuckMessages.ModelDisplay, duck.display());
    }
}
