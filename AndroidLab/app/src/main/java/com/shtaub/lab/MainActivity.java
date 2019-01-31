package com.shtaub.lab;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.NumberPicker;
import android.widget.TextView;
import static java.lang.Math.*;
import android.content.Intent;

import java.util.Locale;

public class MainActivity extends AppCompatActivity {
    public NumberPicker aWidget;
    public NumberPicker bWidget;
    public NumberPicker cWidget;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        aWidget = findViewById(R.id.a);
        bWidget = findViewById(R.id.b);
        cWidget = findViewById(R.id.c);

        aWidget.setMaxValue(9);
        aWidget.setMinValue(1);

        bWidget.setMaxValue(9);
        bWidget.setMinValue(0);

        cWidget.setMaxValue(9);
        cWidget.setMinValue(0);
    }

    private String findRoots(int a, int b, int c) {
        String message;
        if (a == 0) {
            return "Уравнение не квадратное";
        }

        int d = b * b - 4 * a * c;
        double sqrt_val = sqrt(abs(d));
        if (d > 0) {
            message = String.format(Locale.getDefault(),"Корни разные \n %f\n%f",
                    (-b + sqrt_val) / (2 * a), (-b - sqrt_val) / (2 * a));
            return message;
        } else if (d == 0) {
            message = String.format(Locale.getDefault(),"Корни одинаковые \n %f",
                    -(double) b / (2 * a));
            return message;
        } else {
            message = String.format(Locale.getDefault(),"Корни комплексные \n %f + i%f\n%f - i%f",
                    -(double) b / (2 * a), sqrt_val, -(double) b / (2 * a), sqrt_val);
            return message;
        }
    }

    public void buttonClick(View view) {
        int a = aWidget.getValue();
        int b = bWidget.getValue();
        int c = cWidget.getValue();
        TextView viewText = findViewById(R.id.textView);
        viewText.setText(findRoots(a, b, c));
    }

    public void navigateToSecondPage(View view) {
        Intent intent = new Intent(this, Main2Activity.class);
        startActivity(intent);
    }
}
