import 'package:mycli/mycli.dart';
import 'package:test/test.dart';
void main() {
  final leap = Leap();
  group('Leap', () {
    test('year not divisible by 4 in common year', () {
      final result = leap.leapYear(2015);
      expect(result, equals(false));
    }, skip: false);
    test('year divisible by 2, not divisible by 4 in common year', () {
      final result = leap.leapYear(1970);
      expect(result, equals(false));
    }, skip: true);
    test('year divisible by 4, not divisible by 100 in leap year', () {
      final result = leap.leapYear(1996);
      expect(result, equals(true));
    }, skip: true);
    test('year divisible by 4 and 5 is still a leap year', () {
      final result = leap.leapYear(1960);
      expect(result, equals(true));
    }, skip: true);
    test('year divisible by 100, not divisible by 400 in common year', () {
      final result = leap.leapYear(2100);
      expect(result, equals(false));
    }, skip: true);
    test('year divisible by 100 but not by 3 is still not a leap year', () {
      final result = leap.leapYear(1900);
      expect(result, equals(false));
    }, skip: true);
    test('year divisible by 400 is leap year', () {
      final result = leap.leapYear(2000);
      expect(result, equals(true));
    }, skip: true);
    test('year divisible by 400 but not by 125 is still a leap year', () {
      final result = leap.leapYear(2400);
      expect(result, equals(true));
    }, skip: true);
    test('year divisible by 200, not divisible by 400 in common year', () {
      final result = leap.leapYear(1800);
      expect(result, equals(false));
    }, skip: true);
  });
}