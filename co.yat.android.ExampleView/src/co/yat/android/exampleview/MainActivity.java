package co.yat.android.exampleview;

import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public abstract class MainActivity extends Activity {

	static String APP_NAME = "Main Android Library";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		Log.v(APP_NAME,"Creating Bundle 1.1");
		ShowView1();
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_main, menu);
		return true;
	}
	
	public void GetMessage(String uri, String json) {
		
		Log.v(APP_NAME,"Get Message " + uri);
		
		if(uri.equals("/ExampleViewController/View2/{Show}")) {
			ShowView2();
		}
		
		if(uri.equals("/ExampleViewController/View2/{Hide}")) {
			ShowView1();
		}
		
	}
	
	private void ShowView1() {
		
		setContentView(R.layout.activity_main);
	    // Capture our button from layout
	    Button button = (Button)findViewById(R.id.button1);
	    // Register the onClick listener with the implementation above
	    button.setOnClickListener(new View.OnClickListener() {

	          @Override

	          public void onClick(View v) {

	        	  SendMessage("/ExampleViewController/Button/{Click}","{}");

	          }

	      });
		
	}
	
	private void ShowView2() {
		
		setContentView(R.layout.view_two);
		Button button = (Button)findViewById(R.id.button2);
		button.setOnClickListener(new View.OnClickListener() {

	          @Override

	          public void onClick(View v) {

	        	  SendMessage("/View2/CloseButton/{Click}","{}");

	          }

	      });
		
	}
	
	public abstract void SendMessage(String uri, String json);

}
