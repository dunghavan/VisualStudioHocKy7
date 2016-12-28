#ifndef _GAME_H_
#define _GAME_H_

#include<Windows.h>
#include<d3d9.h>
#include<d3dx9.h>
#include"Global.h"
#include"Ball.h"
class CGame{
public:

	CGame(int _nnCmdShow);

	void InitGame();

	void GameRun();

	void GameEnd();

protected:
	int nCmdShow;

	static LRESULT CALLBACK WinProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);

	int InitWindow(int nCmdShow);

	int InitDirectX();

	virtual void RenderFrame(LPDIRECT3DDEVICE9 d3ddv, int Delta);
	virtual void LoadResources(LPDIRECT3DDEVICE9 d3ddv);

	//xu ly input
	void InitKeyboard();
	void ProcessKeyBoard();
	virtual void ProcessInput(LPDIRECT3DDEVICE9 d3ddv, int Delta);
	virtual void OnKeyUp(int KeyCode);
	virtual void OnKeyDown(int KeyCode);

	int IsKeyDown(int KeyCode);

	void RenderFrame();

	DWORD _DeltaTime;

	BYTE  _KeyStates[256]; // DirectInput keyboard state buffer 

	DIDEVICEOBJECTDATA _KeyEvents[GL_KEY_BUFFER_SIZE]; // Buffered keyboard data
};
#endif