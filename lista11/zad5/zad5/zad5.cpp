/*
*
* Tworzenie okna aplikacji
*
*/
#include <windows.h>
#include <Sysinfoapi.h>
#include <stdio.h>
#pragma comment(lib, "user32.lib")
/* Deklaracja wyprzedzająca: funkcja obsługi okna */
LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);
/* Nazwa klasy okna */
char szClassName[] = "PRZYKLAD";
int WINAPI WinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPSTR lpCmdLine,
	int nShowCmd)
{
	HWND hwnd; /* Uchwyt okna */
	MSG messages; /* Komunikaty okna */
	WNDCLASSEX wincl; /* Struktura klasy okna */
	/* Klasa okna */
	wincl.hInstance = hInstance;
	wincl.lpszClassName = szClassName;
	wincl.lpfnWndProc = WindowProcedure; // wskaźnik na funkcję obsługi okna
	wincl.style = CS_DBLCLKS;
	wincl.cbSize = sizeof(WNDCLASSEX);
	/* Domyślna ikona i wskaźnik myszy */
	wincl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hCursor = LoadCursor(NULL, IDC_ARROW);
	wincl.lpszMenuName = NULL;
	wincl.cbClsExtra = 0;
	wincl.cbWndExtra = 0;
	/* Jasnoszare tło */
	wincl.hbrBackground = (HBRUSH)GetStockObject(LTGRAY_BRUSH);
	/* Rejestruj klasę okna */
	if (!RegisterClassEx(&wincl)) return 0;
	/* Twórz okno */
	hwnd = CreateWindowEx(
		0, szClassName,
		"Przykład",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, CW_USEDEFAULT,
		512, 512,
		HWND_DESKTOP, NULL,
		hInstance, NULL);
	ShowWindow(hwnd, nShowCmd);
	/* Pętla obsługi komunikatów */
	while (GetMessage(&messages, NULL, 0, 0))
	{
		/* Tłumacz kody rozszerzone */
		TranslateMessage(&messages);
		/* Obsłuż komunikat */
		DispatchMessage(&messages);
	}
	/* Zwróć parametr podany w PostQuitMessage( ) */
	return messages.wParam;
}
/* Tę funkcję woła DispatchMessage( ) */
LRESULT CALLBACK WindowProcedure(HWND hwnd, UINT message,
	WPARAM wParam, LPARAM lParam)
{
	char sText[] = "zad5";
	HDC         hdc; // kontekst urz¹dzenia
	int         i;
	PAINTSTRUCT ps;
	RECT rect;
	HPEN   hPen;
	HBRUSH hBrush;

	

	switch (message)
	{
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_PAINT:
		SYSTEM_INFO siSysInfo;
		GetSystemInfo(&siSysInfo);
		hdc = BeginPaint(hwnd, &ps);

		GetClientRect(hwnd, &rect);
		SetBkMode(hdc, TRANSPARENT);
		
		//printf("  Processor type: %u\n", siSysInfo.dwProcessorType);
		DrawText(hdc, GetComputerName(), -1, &rect, DT_SINGLELINE | DT_CENTER | DT_VCENTER);
		EndPaint(hwnd, &ps);
		return 0;
	default:
		return DefWindowProc(hwnd, message, wParam, lParam);
	}
	return 0;
}