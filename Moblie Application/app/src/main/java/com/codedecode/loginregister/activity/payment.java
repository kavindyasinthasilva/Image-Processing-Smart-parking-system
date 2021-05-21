package com.codedecode.loginregister.activity;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.Manifest;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.budiyev.android.codescanner.CodeScanner;
import com.budiyev.android.codescanner.CodeScannerView;
import com.budiyev.android.codescanner.DecodeCallback;
import com.codedecode.loginregister.R;
import com.google.zxing.Result;
import com.karumi.dexter.Dexter;
import com.karumi.dexter.PermissionToken;
import com.karumi.dexter.listener.PermissionDeniedResponse;
import com.karumi.dexter.listener.PermissionGrantedResponse;
import com.karumi.dexter.listener.PermissionRequest;
import com.karumi.dexter.listener.single.PermissionListener;

public class payment extends AppCompatActivity {


    CodeScanner codeScanner;
    CodeScannerView scannerView;
    TextView resultData;
    Button scan;

    public View view;

    String Ptext ="Smart Parking System Group 54";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_payment);


        scannerView = findViewById(R.id.scannerview);
        codeScanner = new CodeScanner(this, scannerView);
        resultData = findViewById(R.id.textView13);

        codeScanner.setDecodeCallback(new DecodeCallback() {
            @Override
            public void onDecoded(@NonNull final Result result) {
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        resultData.setText(result.getText());

                        if(Ptext == result.getText() )
                        {

                            String Pid = result.getText();

                            payobj sky = new payobj(Pid);


                            Intent intent = new Intent(payment.this, payweb.class);
                            intent.putExtra("SESSION_ID",result.getText());
                            startActivity(intent);
                            finish();



                        }
                        else {

                            String Pid = result.getText();

                            payobj sky = new payobj(Pid);

                            Intent intent = new Intent(payment.this, payweb.class);
                            intent.putExtra("SESSION_ID",result.getText());
                            startActivity(intent);
                            finish();


                        }





                    }
                });
            }


        });
        scannerView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                codeScanner.startPreview();
            }
        });


    }

    @Override
    protected void onResume() {
        super.onResume();

        //codeScanner.startPreview();

        requestForCamera();
    }

    private void requestForCamera() {


        Dexter.withActivity(this).withPermission(Manifest.permission.CAMERA).withListener(new PermissionListener() {
            @Override
            public void onPermissionGranted(PermissionGrantedResponse response) {
                codeScanner.startPreview();

            }

            @Override
            public void onPermissionDenied(PermissionDeniedResponse response) {

                Toast.makeText(payment.this, "camera permission ReQveard", Toast.LENGTH_SHORT).show();

            }

            @Override
            public void onPermissionRationaleShouldBeShown(PermissionRequest permission, PermissionToken token) {

                token.continuePermissionRequest();

            }
        }).check();


    }
}