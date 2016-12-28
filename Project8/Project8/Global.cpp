#include"Global.h"

HINSTANCE					G_hInstance;		// Handle of the game instance
HWND						G_hWnd;				// Handle of the Game Window
LPDIRECT3D9					G_DirectX;
LPDIRECT3DDEVICE9			G_Device;
LPDIRECT3DSURFACE9			G_BackBuffer;
LPD3DXSPRITE				G_SpriteHandler;
D3DFORMAT					G_BackBufferFormat;
LPDIRECTINPUT8				G_DirectInput;		// The DirectInput object         
LPDIRECTINPUTDEVICE8		G_KeyBoard;			// The keyboard device 


char*						G_GameName = "Sample";
bool						G_IsFullScreen = false;
int							G_ScreenWidth = 800;
int							G_ScreenHeight = 600;
int							G_FrameRate = 60;

void GLTrace(char* format, ...)
{
	char *_traceFile = "C:\\abc\\Sample_TH_game.log";
	int _traceNum = 1;

	if (!_traceNum) return;

	FILE *f = stderr;
	if (_traceFile != NULL)
	{
		if (fopen_s(&f, _traceFile, "a") != 0)
		{
			fprintf(stderr, "WARNING: Failed to open trace file '%s' for writing!\n", _traceFile);
			return;
		}
	}
	va_list ap;
	va_start(ap, format);
	fprintf(f, format, ap);
	va_end(ap);
	fprintf(f, "\n");
	if (_traceFile != NULL) fclose(f);
}

void GLMessage(char* text)
{
	MessageBox(G_hWnd, text, "Sample TH", MB_OK);
}

void GLTitle(char* text){
	SetWindowText(G_hWnd, text);
}