import io.github.bonigarcia.wdm.WebDriverManager;
import org.junit.jupiter.api.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import static org.junit.jupiter.api.Assertions.*;

class TestingFormTest {

    @Test
    void demoTestMethod() {
        assertTrue(true);
    }

    @Test
    void testTitle(){

        WebDriverManager.chromedriver().setup();
        WebDriver driver = new ChromeDriver();
        driver.get("https://localhost:7211/");

        driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[4]/a")).click();
        WebElement titulo = driver.findElement(By.xpath("/html/body/div/main/div/h1"));
        assertEquals("Esta es la primera pregunta","Esta es la primera pregunta");
    }

}