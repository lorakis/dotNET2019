#include <windows.h>
#include <string.h>

LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);
char szClassName[] = "zad1";

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance,
	LPSTR lpszArgument, int nFunsterStil)
{
	HWND hwnd;               
	MSG messages;            
	WNDCLASSEX wincl;        

							
	wincl.hInstance = hThisInstance;
	wincl.lpszClassName = szClassName;
	wincl.lpfnWndProc = WindowProcedure;   
											
	wincl.style = CS_DBLCLKS;
	wincl.cbSize = sizeof(WNDCLASSEX);

	wincl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hCursor = LoadCursor(NULL, IDC_ARROW);
	wincl.lpszMenuName = NULL;
	wincl.cbClsExtra = 0;
	wincl.cbWndExtra = 0;
	wincl.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);

	if (!RegisterClassEx(&wincl)) return 0;

	hwnd = CreateWindowEx(
		0,
		szClassName,
		"zad1",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		512,
		512,
		HWND_DESKTOP,
		NULL,
		hThisInstance,
		NULL
		);

	ShowWindow(hwnd, nFunsterStil);
	while (GetMessage(&messages, NULL, 0, 0))
	{
		TranslateMessage(&messages);
		DispatchMessage(&messages);
	}

	return messages.wParam;
}

int xSize, ySize, x, y, a;
RECT r;
LRESULT CALLBACK WindowProcedure(HWND hwnd, UINT message,
	WPARAM wParam, LPARAM lParam)
{
	char sText[] = "zad1";
	HDC         hdc;
	int         i;
	PAINTSTRUCT ps;


	HPEN   hPen;
	HBRUSH hBrush;

	switch (message)
	{
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_SIZE:
		xSize = LOWORD(lParam);
		ySize = HIWORD(lParam);

		GetClientRect(hwnd, &r);
		InvalidateRect(hwnd, &r, 1);

		break;
	case WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);


		hPen = CreatePen(PS_SOLID, 2, RGB(0, 0, 0));
		SelectObject(hdc, hPen);
		MoveToEx(hdc, xSize / 2, 0, NULL);
		LineTo(hdc, xSize / 2, ySize);
		MoveToEx(hdc, 0, ySize / 2, NULL);
		LineTo(hdc, xSize, ySize / 2);
		DeleteObject(hPen);

		hPen = CreatePen(PS_SOLID, 1, RGB(122, 0, 31));
		SelectObject(hdc, hPen);
		MoveToEx(hdc, xSize / 2, ySize / 2, NULL);
		x = xSize / 2;
		y = ySize / 2;
		a = 0;
		if (ySize < xSize) {
			LineTo(hdc, xSize / 2 + ySize / 2, 0);
		}
		else {
			LineTo(hdc, xSize, ySize / 2 - xSize / 2);
		}
		MoveToEx(hdc, xSize / 2, ySize / 2, NULL);
		if (ySize < xSize) {
			LineTo(hdc, xSize / 2 - ySize / 2, 0);
		}
		else {
			LineTo(hdc, 0, ySize / 2 - xSize / 2);
		}

		DeleteObject(hPen);

		hPen = CreatePen(PS_DASH, 1, RGB(100, 232, 30));
		SelectObject(hdc, hPen);
		MoveToEx(hdc, xSize / 2, ySize / 2, NULL);
		x = xSize / 2;
		y = ySize / 2;
		a = 0;
		while (y < ySize) {
			y = ySize / 2 - a * a;
			x = a + xSize / 2;
			LineTo(hdc, x, y);
			a += 1;
		}
		MoveToEx(hdc, xSize / 2, ySize / 2, NULL);
		x = xSize / 2;
		y = ySize / 2;
		a = 0;
		while (y < ySize) {
			y = ySize / 2 - a * a;
			x = -a + xSize / 2;
			LineTo(hdc, x, y);
			a += 1;
		}
		DeleteObject(hPen);
		EndPaint(hwnd, &ps);
		break;

	default:
		return DefWindowProc(hwnd, message, wParam, lParam);
	}
	return 0;
}