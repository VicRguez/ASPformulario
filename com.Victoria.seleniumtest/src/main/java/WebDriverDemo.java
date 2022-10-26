import java.util.List;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import io.github.bonigarcia.wdm.WebDriverManager;
public class WebDriverDemo {
//https://dzone.com/articles/selenium-with-java-google-search
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		WebDriverManager.chromedriver().setup();
		


		WebDriver driver = new ChromeDriver();
		
		driver.get("https://www.google.es");
		
		driver.findElement(By.id("L2AGLb"))
		.click();
		
		
		driver.findElement(By.name("q"))
		.sendKeys("el tiempo");
		 //btnK
		
		driver.findElement(By.name("btnK")).submit();
		
		List<WebElement> findElements = driver.findElements(By.xpath("//*[@id='rso']//h3/a"));                
		
		findElements.get(0).click(); 
		
		
		
		
		
		
		
	}
	
	
	
	public void primerEjercicio() {
		
		WebDriver driver = new ChromeDriver();

		
		driver.get("https://accounts.lambdatest.com/register");
	    
		// Enter your login email id
        driver.findElement(By.id("email"))
            .sendKeys("xykjhkz@gmail.com");
  
        // Enter your login full name
        driver.findElement(By.id("name"))
            .sendKeys("xyz khigi");
        
     // Enter your login password
        driver.findElement(By.id("userpassword"))
            .sendKeys("xyz12345");
        
     // Enter your login full name
        driver.findElement(By.id("phone"))
            .sendKeys("638895756");
  
     // Enter your login full name
        driver.findElement(By.xpath("//label/samp"))
            .click(); 
        
        //
        driver.findElement(By.xpath("//button[text()=\"FREE SIGN UP\"]"))
            .click();
	}

	public void segundoEjercicio() {
		WebDriver driver = new ChromeDriver();
		
		driver.get("https://www.google.es");
		//L2AGLb
		
		driver.findElement(By.id("L2AGLb"))
        .click();
		
		driver.findElement(By.name("q"))
		.sendKeys("2+2");
		 //btnK
		
		driver.findElement(By.name("btnK")).click();
	}
	
	public void tercerEjercicio() {
		
		WebDriver driver = new ChromeDriver();
				
		driver.get("https://www.google.es");
		
		driver.findElement(By.id("L2AGLb"))
		.click();
		
		
		driver.findElement(By.name("q"))
		.sendKeys("which is the most viewed science fiction video trailers");
		 //btnK
		
		driver.findElement(By.name("btnK")).submit();
		
		
		List<WebElement> findElements = driver.findElements(By.xpath("//a[@class='X5OiLe']"));
		
		findElements.get(1).click(); 
		
		driver.findElement(By.xpath("//tp-yt-paper-button[yt-formatted-string[text()='Reject all']]"))
		.click();
	}
}
