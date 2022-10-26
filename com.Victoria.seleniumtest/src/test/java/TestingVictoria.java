

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;

public class TestingVictoria {

	@Test
	public void test() {
		WebDriverManager.chromedriver().setup();
		


		WebDriver driver = new ChromeDriver();
		
		driver.get("https://localhost:7211/");
		
		driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[3]/a"))
		.click();
		
		driver.findElement(By.xpath("/html/body/div/main/table/tbody/tr[1]/td[3]/div[1]/a"))
		.click();
		
		String actualUrl="https://localhost:7211/Preguntas/Create/1";

		String expectedUrl= driver.getCurrentUrl();

		Assert.assertEquals(expectedUrl,actualUrl);
	}

}
