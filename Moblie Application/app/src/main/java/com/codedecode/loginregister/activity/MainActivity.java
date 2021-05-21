package com.codedecode.loginregister.activity;

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationManager;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.provider.Settings;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.VideoView;

import androidx.core.app.ActivityCompat;

import com.codedecode.loginregister.R;
import com.codedecode.loginregister.helper.SQLiteHandler;
import com.codedecode.loginregister.helper.SessionManager;
import java.util.HashMap;

public class MainActivity extends Activity {

    private VideoView mVideoView;
    private SQLiteHandler db;
    private SessionManager session;


    private static final int REQUEST_LOCATION = 1;
    Button btnGetLocation;
    TextView showLocation;
    LocationManager locationManager;
    String latitude, longitude;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.KITKAT) {
            Window w = getWindow();
            w.setFlags(WindowManager.LayoutParams.FLAG_LAYOUT_NO_LIMITS, WindowManager.LayoutParams.FLAG_LAYOUT_NO_LIMITS);
        }

        TextView txtName = findViewById(R.id.name);
        TextView txtEmail = findViewById(R.id.email);
        Button btnLogout = findViewById(R.id.btnLogout);







        Button btListe = findViewById(R.id.Now);
        btListe.setOnClickListener(new View.OnClickListener()
        {    public void onClick(View v)
        {
            Intent	intent = new Intent(MainActivity.this, webmodule.class);
            startActivity(intent);
            finish();
        }
        });





        Button btListe1 = findViewById(R.id.now3);
        btListe1.setOnClickListener(new View.OnClickListener()
        {    public void onClick(View v)
        {
            Intent	intent = new Intent(MainActivity.this, mylocation.class);
            startActivity(intent);
            finish();
        }
        });


        Button btListe2 = findViewById(R.id.now5);
        btListe2.setOnClickListener(new View.OnClickListener()
        {    public void onClick(View v)
        {
            Intent	intent = new Intent(MainActivity.this, payment.class);
            startActivity(intent);
            finish();
        }
        });




        // SqLite database handler
        db = new SQLiteHandler(getApplicationContext());

        // session manager
        session = new SessionManager(getApplicationContext());

        if (!session.isLoggedIn()) {
            logoutUser();
        }

        // Fetching user details from SQLite
        HashMap<String, String> user = db.getUserDetails();

        String name = user.get("name");
        String email = user.get("email");

        // Displaying the user details on the screen
        txtName.setText(name);
        txtEmail.setText(email);

        // Logout button click event
        btnLogout.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                logoutUser();
            }
        });
    }



    private void logoutUser() {

        session.setLogin(false);

        db.deleteUsers();
        // Launching the login activity
        Intent intent = new Intent(MainActivity.this, LoginActivity.class);
        startActivity(intent);
        finish();
    }
}