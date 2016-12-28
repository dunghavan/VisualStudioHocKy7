#include "logger.h"
#pragma warning(disable:4996)

Logger* Logger::_Instance = 0;
Logger::Logger(){
	std::ofstream ofs;
	ofs.open("log_file.txt", std::ofstream::out | std::ofstream::trunc);
	ofs.close();
}
Logger* Logger::getInstance(){
	if (_Instance == 0)
	{
		_Instance = new Logger();
	}
	return _Instance;
}
void Logger::write_text_to_log_file(const std::string &text){
	//time_t rawtime;
	//struct tm * timeinfo;

	//time(&rawtime);
	//timeinfo = localtime(&rawtime);
	////printf("Current local time and date: %s", asctime(timeinfo));
	time_t     now = time(0);
	struct tm  tstruct;
	char       buf[80];
	tstruct = *localtime(&now);
	strftime(buf, sizeof(buf), "%Y-%m-%d %X", &tstruct);
	std::ofstream log_file(
		"log_file.txt", std::ios_base::out | std::ios_base::app);
	log_file << "[" << buf << "]  " << text << std::endl;
}
