package com.example.calc;

import android.app.Activity;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Calculator extends Activity implements OnClickListener, TextWatcher {
	EditText etResult;
	Button btnPlus, btnMinus, btnMultiply, btnDivide, btnClear, btnAbs, btnDiv, btnMod, btnStepen, button0, button1,
			button2, button3, button4, button5, button6, button7, button8, button9, btnCalculate;

	int int_num1, int_num2, int_result;
	double double_num1, double_num2, double_result;


	private double sum(double a, double b) {
		double c = a + b;
		return c;
	}

	private double subtract(double a, double b) {
		double c = a - b;
		return c;
	}

	private double multiply(double a, double b) {
		double c = a * b;
		return c;
	}

	private double divide(double a, double b) {
		double c = a / b;
		return c;
	}

	@Override
	public void afterTextChanged(Editable arg0) {
	}

	@Override
	public void beforeTextChanged(CharSequence arg0, int arg1, int arg2, int arg3) {
	}

	@Override
	public void onTextChanged(CharSequence s, int start, int before, int count) {

		if (etResult.getText().length() == 0) {
			if (btnAbs.isEnabled()) {
				btnAbs.setEnabled(false);
				btnCalculate.setEnabled(false);
			}
		} else if (!btnAbs.isEnabled()) {
			btnAbs.setEnabled(true);
			btnCalculate.setEnabled(true);
		}
	}
}