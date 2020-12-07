# Tube Feeder
 - 장비 전원 On 후 단말기에서 Start를 누르면 제어보드를 통해 tube를 바코드에게 가져다 주면 읽은 바코드 번호를 저장하는 시스템
 - 단말기에 설치되어 제어장치와 바코드 리더기와 통신하며 제어하는 프로그램입니다.
 
## 하드웨어 구성
 - 임베디드 컴퓨터 : 사용자 인터페이스 제공, 모든 시스템 동작을 컨트롤함
 - 바코드 리더기 : 제품 바코드를 읽어 임베디드 컴퓨터로 전송해줌
 - 제어보드 : 임베디드 컴퓨터와 통신하며 기계들의 동작시킴

## 소프트웨어 요구사항
 ### 확인해볼 것
 - [x] 내 환경에서 빌드한 .exe 파일이 타겟 기기(windows ce)에서 실행 되는지 확인
 - [ ] ~~바코드 리더기 드라이버 설치 후 컴포트를 통해 데이터 얻어지는지 확인~~
 - [x] 바코드 리더기를 통해 데이터 얻어지는지 확인(키보드 입력형태로 데이터 입력되는 것 확인)
 - [x] 컴포트 rx,tx를 점프선으로 연결해 보내기와 받기 되는 것 확인
 - [ ] 단말기와 기계장치간 컴포트를 통해 데이터 오고가는 것 확인
 
 ### 개발 요구사항
 - [ ] 바코드 리더기로부터 바코드정보를 받음 
 - [ ] 받은 바코드정보를 저장함 (파일 또는 Excel, 각각 파일은 날짜 단위로 나눔)
 - [ ] 제어보드와의 통신 구현: 제어장치에게 전송(시작해라, 바코드 읽음, 모터속도 설정)
 - [ ] 제어보드와의 통신 구현: 제어장치로부터 수신(바코드 읽어라, 기계에 재밍이 발생함)

## Todo
> 기능 구현 목록
 - [x] 바코드 입력시 파일(./ScanLog/YYYYMMDD.txt)에 입력&저장
 
> 이외 구현 목록
 - [ ] 에러 처리 (컴포트 연결 실패, 바코드 연결 실패 등등)
 - [ ] GUI 정리

## 참고
 - 임베디드 컴퓨터 정보 (IEC1000)
   - [단말기 통합 개요](https://hnsts.co.kr//ReferenceRoom/ProductRelated#product5)
   - [단말기 메뉴얼](https://hnsts.co.kr/UserFiles/attachment/data_down/1-iecseries.pdf)
   - [단말기 스타팅개발 가이드](https://hnsts.co.kr/UserFiles/attachment/data_down/%EC%8A%A4%ED%83%80%ED%8C%85%EB%94%94%EB%B2%A8%EB%A1%9C%ED%8D%BC%EA%B0%80%EC%9D%B4%EB%93%9C-C.pdf)
   - [단말기 하드웨어 개요](https://www.hnsts.co.kr/Hardware/Iec1000)
   
   - https://www.hnsts.co.kr/Hardware/Iec1000
   - https://www.icbanq.com/P005658680
   - Windows CE 6.0
   - 에뮬레이터 : https://www.google.com/search?lr=lang_ko&tbs=lr:lang_1ko&q=%EC%9C%88%EB%8F%84%EC%9A%B0+CE+%EC%97%90%EB%AE%AC%EB%A0%88%EC%9D%B4%ED%84%B0&sa=X&ved=2ahUKEwj2p7es0q7tAhVuF6YKHZHWAzYQ1QIoAHoECAUQAQ&biw=1920&bih=934
  
 - 바코드 리더기 정보 
   - 3310G 하니웰(USB)
   - 인터페이스 : (usb 드라이버를 통한 comport통신, rs232통신 )
   - [메뉴얼-en](https://www.honeywellaidc.com/ko-kr/-/media/en/files-public/technical-publications/barcode-scanners/vuquest-3310g/3310-ug.pdf)
   - [퀵 메뉴얼-kr](https://aidc.honeywell.com/CatalogDocuments/3310-KO-QS%20Rev%20C%201-13.pdf)
   - usb 드라이버 다운로드 : http://idnext.co.kr/bbs/board.php?bo_table=4010&wr_id=29
   - usb 드라이버(WinCE용 참고): http://m.ezdaq.com/board/?id=board3&popup=&iframe=&goods_seq=&perpage=&page=&category=%EB%93%9C%EB%9D%BC%EC%9D%B4%EB%B2%84&search_text=
   - 바코드 presentation 모드와, streaming presentation모드 차이 : https://www.l-trondirect.com/blog/what-does-presentation-mode-mean-on-a-barcode-scanner/
 
 - 제어보드(MCU) 정보
   - 인터페이스 : comport serial rs232
