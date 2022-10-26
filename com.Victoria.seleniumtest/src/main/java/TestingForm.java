import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;

public class TestingForm {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		WebDriverManager.chromedriver().setup();
		


		WebDriver driver = new ChromeDriver();
		
		driver.get("https://localhost:7211/");
		
		driver.findElement(By.xpath("/html/body/header/nav/div/div/ul/li[4]/a"))
		.click();
		
		/*// Enter your login email id
        driver.findElement(By.id("email"))
            .sendKeys("xykjhkz@gmail.com");*/
	}

}
