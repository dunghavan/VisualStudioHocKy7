#ifndef _CAMERA_H_
#define _CAMERA_H_


#include "Global.h"

class GCamera
{
public:
	D3DXVECTOR2 viewport;		//Thiết lập tọa độ của camera	
	int _maxSize, _minSize;
	float x;
	float y;
	bool IsFollow;
	float alpha;
	D3DXVECTOR2 scale;
	float xscale;
	float xalpha;
	GCamera();
	D3DXVECTOR3 CenterSprite(int x, int y);	//Tìm tọa độ center của sprite
	void UpdateCamera(int x);
	void UpdateCamera(float x, float y);
	void UpdateCamera(int &w, int &h);
	void UpdateCamera();
	void SetSizeMap(int _max, int _min);
	D3DXVECTOR2 Transform(int x, int y);		//Hàm transform, chuyển tọa độ viewport về tọa độ world

};
extern GCamera  Camera;
#endif