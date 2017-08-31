package fr.insee.swagger;

public class Identifier {
	private String Item1;
	private String Item2;
	private String Item3;
	
	public String getItem1() {
		return Item1;
	}
	public void setItem1(String item1) {
		Item1 = item1;
	}
	public String getItem2() {
		return Item2;
	}
	public void setItem2(String item2) {
		Item2 = item2;
	}
	public String getItem3() {
		return Item3;
	}
	public void setItem3(String item3) {
		Item3 = item3;
	}
	
	@Override
	public String toString()
	{
		
		StringBuilder strBuild = new StringBuilder();
		strBuild.append("Item1: ");
		strBuild.append(this.Item1);
		strBuild.append("\n");
		strBuild.append("Item2 :");
		strBuild.append(this.Item2);
		strBuild.append("\n");
		strBuild.append("Item3 :");
		strBuild.append(this.Item3);
		strBuild.append("\n");
		return strBuild.toString();
	}
	
	
}
